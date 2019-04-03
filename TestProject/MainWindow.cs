using System;
using Gtk;
using LibHelper;

public partial class MainWindow : Window
{
    #region Private fields & properties

    private MsgHelper _msgHelper = MsgHelper.Instance;

    #endregion

    public MainWindow() : base(WindowType.Toplevel) => Build();

    private void OnButtonExitClicked(object sender, EventArgs e)
    {
        Application.Quit();
        //a.RetVal = true;
    }

    private void OnButtonShowClicked(object sender, EventArgs e)
    {
        _msgHelper.Show(
            _msgHelper.GetDialogFlags(comboboxDialogFlags),
            _msgHelper.GetMessageType(comboboxMessageType),
            _msgHelper.GetButtonsType(comboboxButtonsType), 
            entryMessage.Text);
    }
}

