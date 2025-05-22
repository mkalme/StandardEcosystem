using System;
using System.Drawing;

namespace CustomDialogs {
    public class PasswordGeneratorDialogProfile {
        public Image Image { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }
        public string Password { get; set; }
        public string InputName { get; set; }

        public IPasswordGenerator PasswordGenerator { get; set; }
        public Func<string, bool> PasswordValidator { get; set; }

        public static PasswordGeneratorDialogProfile NewPassword {
            get {
                return new PasswordGeneratorDialogProfile() { 
                    Image = Properties.Resources._64pxChangePassword,
                    Title = "New password",
                    Message = "Enter the new password",
                    InputName = "Password",
                    PasswordGenerator = new AsciiStringPasswordGenerator(),
                    PasswordValidator = p => {
                        return KeyExtensions.ValidateText(p);
                    }
                };
            }
        }
        public static PasswordGeneratorDialogProfile NewKey {
            get {
                return new PasswordGeneratorDialogProfile() {
                    Image = Properties.Resources._64pxKey,
                    Title = "New key",
                    Message = "Enter the new key",
                    InputName = "Key",
                    PasswordGenerator = new KeyGenerator(),
                    PasswordValidator = KeyExtensions.KeyValidator
                };
            }
        }
    }
}
