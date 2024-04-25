using StudioCore.Editors.MsbEditor;
using StudioCore.Editors.ParamEditor;
using StudioCore.Editors.TextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioCore.Editors;

public static class EditorContainer
{
    public static MsbEditorScreen MsbEditor { get; set; }
    public static ModelEditorScreen ModelEditor { get; set; }
    public static TextEditorScreen TextEditor { get; set; }
    public static ParamEditorScreen ParamEditor { get; set; }
}
