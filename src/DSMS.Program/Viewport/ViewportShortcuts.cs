using StudioCore.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioCore.ViewportNS;

public class ViewportShortcuts
{
    public Viewport Parent;
    public DSMS BaseEditor;

    public ViewportShortcuts(DSMS baseEditor, Viewport parent)
    {
        this.BaseEditor = baseEditor;
        Parent = parent;
    }

    public void Update()
    {

    }
}

