using System;
using Gtk;

namespace LibHelper
{
    public class MsgHelper
    {
        #region Design pattern - Singleton

        private static readonly Lazy<MsgHelper> _instance = new Lazy<MsgHelper>(() => new MsgHelper());

        public static MsgHelper Instance { get { return _instance.Value; } }

        private MsgHelper() { }

        #endregion

        public void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
        {
            var md = new MessageDialog(parent_window, flags, msgtype, btntype, msg);
            md.Run();
            md.Destroy();
        }

        public void Show(DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
        {
            var md = new MessageDialog(null, flags, msgtype, btntype, msg);
            md.Run();
            md.Destroy();
        }

        public void Show(MessageType msgtype, ButtonsType btntype, string msg)
        {
            var md = new MessageDialog(null, DialogFlags.Modal, msgtype, btntype, msg);
            md.Run();
            md.Destroy();
        }

        public void Show(ButtonsType btntype, string msg)
        {
            var md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, btntype, msg);
            md.Run();
            md.Destroy();
        }

        public void Show(string msg)
        {
            var md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, msg);
            md.Run();
            md.Destroy();
        }

        public DialogFlags GetDialogFlags(ComboBox cb)
        {
            var dialogFlags = default(DialogFlags);
            switch (cb.ActiveText)
            {
                case "DestroyWithParent":
                    dialogFlags = DialogFlags.DestroyWithParent;
                    break;
                case "Modal":
                    dialogFlags = DialogFlags.Modal;
                    break;
                case "NoSeparator":
                    dialogFlags = DialogFlags.NoSeparator;
                    break;
            }
            return dialogFlags;
        }

        public MessageType GetMessageType(ComboBox cb)
        {
            var messageType = default(MessageType);
            switch (cb.ActiveText)
            {
                case "Error":
                    messageType = MessageType.Error;
                    break;
                case "Info":
                    messageType = MessageType.Info;
                    break;
                case "Other":
                    messageType = MessageType.Other;
                    break;
                case "Question":
                    messageType = MessageType.Question;
                    break;
                case "Warning":
                    messageType = MessageType.Warning;
                    break;
            }
            return messageType;
        }

        public ButtonsType GetButtonsType(ComboBox cb)
        {
            var buttonsType = default(ButtonsType);
            switch (cb.ActiveText)
            {
                case "Cancel":
                    buttonsType = ButtonsType.Cancel;
                    break;
                case "Close":
                    buttonsType = ButtonsType.Close;
                    break;
                case "None":
                    buttonsType = ButtonsType.None;
                    break;
                case "YesNo":
                    buttonsType = ButtonsType.YesNo;
                    break;
                case "Ok":
                    buttonsType = ButtonsType.Ok;
                    break;
                case "OkCancel":
                    buttonsType = ButtonsType.OkCancel;
                    break;
            }
            return buttonsType;
        }
    }
}
