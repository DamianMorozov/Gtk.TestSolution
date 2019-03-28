using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
    {
        MessageDialog md = new MessageDialog(parent_window, flags, msgtype, btntype, msg);
        md.Run();
        md.Destroy();
    }

    public static void Show(string msg)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, msg);
        md.Run();
        md.Destroy();
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        Show("Button1");
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        Show("Button2");
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        Show("Button3");
    }
}
