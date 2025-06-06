﻿using Andre.Formats;
using Hexa.NET.ImGui;
using Microsoft.Extensions.Logging;
using StudioCore.Editor;
using StudioCore.Interface;
using System;
using System.Numerics;
using System.Reflection;

namespace StudioCore.Editors.ParamEditor;

public class ParamFieldInput
{
    private static object _editedPropCache;
    private static object _editedTypeCache;
    private static object _editedObjCache;
    private static bool _changedCache;
    private static bool _committedCache;

    public static unsafe void DisplayFieldInput(Type typ, object oldval, ref object newval, bool isBool, bool isInvertedPercentage)
    {
        _changedCache = false;
        _committedCache = false;
        ImGui.SetNextItemWidth(-1);

        try
        {
            if (isBool)
            {
                dynamic val = oldval;
                bool checkVal = val > 0;
                if (ImGui.Checkbox("##valueBool", ref checkVal))
                {
                    newval = Convert.ChangeType(checkVal ? 1 : 0, oldval.GetType());
                    _editedPropCache = newval;
                    _changedCache = true;
                }

                _committedCache = ImGui.IsItemDeactivatedAfterEdit();
                ImGui.SameLine();
                ImGui.SetNextItemWidth(-1);
            }
        }
        catch
        {
        }

        if (typ == typeof(long))
        {
            var val = (long)oldval;
            var strval = $@"{val}";
            if (ImGui.InputText("##value", ref strval, 128))
            {
                var res = long.TryParse(strval, out val);
                if (res)
                {
                    newval = val;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else if (typ == typeof(int))
        {
            var val = (int)oldval;
            if (ImGui.InputInt("##value", ref val))
            {
                newval = val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(uint))
        {
            var val = (uint)oldval;
            var strval = $@"{val}";
            if (ImGui.InputText("##value", ref strval, 16))
            {
                var res = uint.TryParse(strval, out val);
                if (res)
                {
                    newval = val;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else if (typ == typeof(short))
        {
            int val = (short)oldval;
            if (ImGui.InputInt("##value", ref val))
            {
                newval = (short)val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(ushort))
        {
            var val = (ushort)oldval;
            var strval = $@"{val}";
            if (ImGui.InputText("##value", ref strval, 5))
            {
                var res = ushort.TryParse(strval, out val);
                if (res)
                {
                    newval = val;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else if (typ == typeof(sbyte))
        {
            int val = (sbyte)oldval;
            if (ImGui.InputInt("##value", ref val))
            {
                newval = (sbyte)val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(byte))
        {
            var val = (byte)oldval;
            var strval = $@"{val}";
            if (ImGui.InputText("##value", ref strval, 3))
            {
                var res = byte.TryParse(strval, out val);
                if (res)
                {
                    newval = val;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else if (typ == typeof(bool))
        {
            var val = (bool)oldval;
            if (ImGui.Checkbox("##value", ref val))
            {
                newval = val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(float))
        {
            // Display in-game form of this property (i.e. 75% instead of 0.25)
            if (isInvertedPercentage && CFG.Current.Param_ShowTraditionalPercentages)
            {
                float fakeVal = (1 - (float)oldval) * 100;

                if (ImGui.InputFloat("##value", ref fakeVal, 0.0f, 1.0f, Utils.ImGui_InputFloatFormat(fakeVal, 3, 3)))
                {
                    // Restore actual value
                    float realVal = (1 - (fakeVal / 100));
                    newval = realVal;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
            else
            {
                var val = (float)oldval;
                if (ImGui.InputFloat("##value", ref val, 0.1f, 1.0f, Utils.ImGui_InputFloatFormat(val)))
                {
                    newval = val;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else if (typ == typeof(double))
        {
            var tempValue = (double)oldval;
            double step = 0.1;
            double stepFast = 1.0;
            var format = InterfaceUtils.CreateFloatFormat((float)tempValue);
            byte* formatPtr = InterfaceUtils.StringToUtf8(format);

            if (ImGui.InputScalar($"##value", ImGuiDataType.Double, &tempValue, &step, &stepFast, formatPtr))
            {
                newval = tempValue;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(string))
        {
            var val = (string)oldval;
            if (val == null)
                val = "";

            if (ImGui.InputText("##value", ref val, 128))
            {
                newval = val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(Vector2))
        {
            var val = (Vector2)oldval;
            if (ImGui.InputFloat2("##value", ref val))
            {
                newval = val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(Vector3))
        {
            var val = (Vector3)oldval;
            if (ImGui.InputFloat3("##value", ref val))
            {
                newval = val;
                _editedPropCache = newval;
                _changedCache = true;
            }
        }
        else if (typ == typeof(byte[]))
        {
            var bval = (byte[])oldval;
            var val = ParamUtils.Dummy8Write(bval);
            if (ImGui.InputText("##value", ref val, 9999))
            {
                var nval = ParamUtils.Dummy8Read(val, bval.Length);
                if (nval != null)
                {
                    newval = nval;
                    _editedPropCache = newval;
                    _changedCache = true;
                }
            }
        }
        else
        {
            // Using InputText means IsItemDeactivatedAfterEdit doesn't pick up random previous item
            var implMe = "ImplementMe";
            ImGui.InputText("ImplementMe", ref implMe, 256, ImGuiInputTextFlags.ReadOnly);
        }

        _committedCache |= ImGui.IsItemDeactivatedAfterEdit();
    }

    public static void SetLastPropertyManual(object newval)
    {
        _editedPropCache = newval;
        _changedCache = true;
        _committedCache = true;
    }

    public static bool UpdateProperty(ActionManager executor, object obj, PropertyInfo prop, object oldval,
        int arrayindex = -1)
    {
        if (_changedCache)
        {
            _editedObjCache = obj;
            _editedTypeCache = prop;
        }
        else if (_editedPropCache != null && _editedPropCache != oldval)
        {
            _changedCache = true;
        }

        if (_changedCache)
        {
            ChangeProperty(executor, _editedTypeCache, _editedObjCache, _editedPropCache, ref _committedCache,
                arrayindex);
        }

        //Smithbox.EditorHandler.TextureViewer.ImagePreview.InvalidatePreviewImage();

        return _changedCache && _committedCache;
    }

    private static void ChangeProperty(ActionManager executor, object prop, object obj, object newval,
        ref bool committed, int arrayindex = -1)
    {
        if (committed)
        {
            if (newval == null)
            {
                // Safety check warned to user, should have proper crash handler instead
                // TaskLogs.AddLog("ParamEditorCommon: Property changed was null", LogLevel.Warning);
                return;
            }

            PropertiesChangedAction action;
            if (arrayindex != -1)
            {
                action = new PropertiesChangedAction((PropertyInfo)prop, arrayindex, obj, newval);
            }
            else
            {
                action = new PropertiesChangedAction((PropertyInfo)prop, obj, newval);
            }

            executor.ExecuteAction(action);
        }
    }
}
