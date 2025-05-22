using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;

namespace CustomDialogs {
    public static class CustomDialog {
        public static string ShowMessage(string title, string message, Image icon = null, SystemSound sound = null) {
            ButtonInputDialog dialog = new ButtonInputDialog(title, message, "Ok") { 
                Image = icon
            };

            if (sound != null) sound.Play();
            dialog.ShowDialog();

            return dialog.DialogClosed ? "Close" : dialog.Result;
        }
        public static string ShowMessage(string title, string message, Image icon, SystemSound sound, params string[] buttons) {
            ButtonInputDialog dialog = new ButtonInputDialog(title, message, buttons) {
                Image = icon
            };

            if (sound != null) sound.Play();
            dialog.ShowDialog();

            return dialog.DialogClosed ? "Closed" : dialog.Result;
        }

        public static InputResult<string> ShowTextInput(string title, string message, string inputText = "", Image icon = null, Func<string, bool> validator = null) {
            TextInputDialog dialog = new TextInputDialog(title, message, inputText, icon, validator == null ? text => true : validator);
            dialog.ShowDialog();

            return new InputResult<string>(dialog.InputText, dialog.DialogClosed);
        }

        public static InputResult<string> ShowPasswordInput(Func<string, bool> validator, string title = "Password", string message = "Enter the password", string password = "") {
            PasswordInputDialog dialog = new PasswordInputDialog(title, message, "Password", password);
            if (validator != null) dialog.Validator = validator;

            dialog.ShowDialog();

            return new InputResult<string>(dialog.Password, dialog.DialogClosed);
        }
        public static InputResult<byte[]> ShowKeyInput(Func<string, bool> validator, string title = "Input key", string message = "Enter the key", string password = "") {
            PasswordInputDialog dialog = new PasswordInputDialog(title, message, "Key", password);
            if (validator != null) dialog.Validator = validator;

            dialog.ShowDialog();

            return new InputResult<byte[]>(Encoding.ASCII.GetBytes(dialog.Password), dialog.DialogClosed);
        }

        public static void ShowError(Exception exception) {
            ErrorDialog dialog = new ErrorDialog($"Error | {exception.Message}", exception.ToString(), true);
            
            SystemSounds.Hand.Play();
            dialog.ShowDialog();
        }
        public static void ShowError(string errorMessage, string errorBody, bool showBorders = false, bool sizeable = false) {
            ErrorDialog dialog = new ErrorDialog(errorMessage, errorBody, showBorders);

            if (!sizeable) {
                dialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                dialog.MaximizeBox = false;
            }

            SystemSounds.Hand.Play();
            dialog.ShowDialog();
        }

        public static InputResult<string> ShowBrowser(BrowseType browseType, string fileFilter = "", string selectedPath = "") {
            BrowserDialog dialog = new BrowserDialog(browseType, fileFilter, selectedPath);
            dialog.ShowDialog();

            return new InputResult<string>(dialog.SelectedPath, dialog.DialogClosed);
        }

        public static SaveConfirmation ShowSaveConfirmation() {
            ButtonInputDialog dialog = new ButtonInputDialog(
                "Save",
                "There are some changes. Do you want to save them?",
                "Save", "Don't Save", "Cancel") {
                Image = Properties.Resources._64pxSave
            };

            SystemSounds.Asterisk.Play();
            dialog.ShowDialog();

            if (dialog.DialogClosed) return SaveConfirmation.Close;

            switch (dialog.Result) {
                case "Save": return SaveConfirmation.Save;
                case "Don't Save": return SaveConfirmation.DontSave;
                default: return SaveConfirmation.Cancel;
            }
        }

        public static InputResult<string> ShowPasswordGenerator(PasswordGeneratorDialogProfile profile) {
            Image image;
            if (profile.Image == null) image = Properties.Resources._64pxChangePassword;
            else image = profile.Image;

            PasswordGeneratorDialog dialog = new PasswordGeneratorDialog(image, profile.Title, profile.Message, profile.Password) {
                InputName = profile.InputName,
                PasswordGenerator = profile.PasswordGenerator,
                Validator = profile.PasswordValidator
            };
            dialog.ShowDialog();

            return new InputResult<string>(dialog.Password, dialog.DialogClosed);
        }
        public static InputResult<string> ShowPasswordGenerator(string title = "New password", string message = "Enter the new password", string password = "") {
            var profile = PasswordGeneratorDialogProfile.NewPassword;
            profile.Title = title;
            profile.Message = message;
            profile.Password = password;

            return ShowPasswordGenerator(profile);
        }
        public static InputResult<byte[]> ShowKeyGenerator(string title = "New key", string message = "Enter the new key", string password = "") {
            var profile = PasswordGeneratorDialogProfile.NewKey;
            profile.Title = title;
            profile.Message = message;
            profile.Password = password;

            InputResult<string> result = ShowPasswordGenerator(profile);

            return new InputResult<byte[]>(Encoding.ASCII.GetBytes(result.Value), result.DialogClosed);
        }

        public static InputResult<IList<object>> ShowItemSelector(ViewController viewController, IDataGridViewSelectionControl selectionControl, ItemSelectorProfile profile) {
            ItemSelector selector = new ItemSelector(viewController, selectionControl, profile);
            selector.ShowDialog();

            return new InputResult<IList<object>>(selector.SelectedItems, selector.DialogClosed);
        }

        public static bool ShowDeletionConfirmation(string verb = "Delete") {
            string result = ShowMessage(verb, $"Are you sure you want to {verb.ToLower()} this?",
                Properties.Resources._64pxTrash, SystemSounds.Hand, verb, "No");

            return result == verb;
        }

        public static void ShowDateListViewer(IEnumerable<DateTime> dates, Image image, string title, string columnHeaderText) {
            DateListViewer viewer = new DateListViewer(dates, image, title, columnHeaderText);
            viewer.ShowDialog();
        }

        public static void ShowInformationViewer(BuildInformationPanel buildPanel, KeyInformationPanel keyPanel, ProgramInformationPanel programPanel) {
            InformationViewer viewer = new InformationViewer(buildPanel, keyPanel, programPanel);
            viewer.ShowDialog();
        }

        public static InputResult<ISet<string>> ShowTextCollectionEditor(ISet<string> values, string valueName, Func<IEnumerable<string>> addFunction, Func<string, Image> getIconFunction, Icon icon) {
            TextCollectionEditor editor = new TextCollectionEditor(values, valueName, addFunction, getIconFunction) { 
                Icon = icon
            };
            editor.ShowDialog();

            return new InputResult<ISet<string>>(editor.Values, editor.DialogClosed);
        }
    }
}
