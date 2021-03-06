using System.Windows;
using System.Windows.Controls;

namespace Wox.Plugin.Shell
{
    public partial class CMDSetting : UserControl
    {
        private readonly Settings _settings;

        public CMDSetting(Settings settings)
        {
            InitializeComponent();
            _settings = settings;
        }

        private void CMDSetting_OnLoaded(object sender, RoutedEventArgs re)
        {
            ReplaceWinR.IsChecked = _settings.ReplaceWinR;
            LeaveShellOpen.IsChecked = _settings.LeaveShellOpen;
            AlwaysRunAsAdministrator.IsChecked = _settings.RunAsAdministrator;
            LeaveShellOpen.IsEnabled = _settings.Shell != Shell.RunCommand;

            LeaveShellOpen.Checked += (o, e) =>
            {
                _settings.LeaveShellOpen = true;
            };

            LeaveShellOpen.Unchecked += (o, e) =>
            {
                _settings.LeaveShellOpen = false;
            };

            AlwaysRunAsAdministrator.Checked += (o, e) =>
            {
                _settings.RunAsAdministrator = true;
            };

            AlwaysRunAsAdministrator.Unchecked += (o, e) =>
            {
                _settings.RunAsAdministrator = false;
            };

            ReplaceWinR.Checked += (o, e) =>
            {
                _settings.ReplaceWinR = true;
            };
            ReplaceWinR.Unchecked += (o, e) =>
            {
                _settings.ReplaceWinR = false;
            };

            ShellComboBox.SelectedIndex = (int) _settings.Shell;
            if (_settings.SupportWSL)
            {
                ShellComboBox.Items.Add("Bash");
            }
            ShellComboBox.SelectionChanged += (o, e) =>
            {
                _settings.Shell = (Shell) ShellComboBox.SelectedIndex;
                LeaveShellOpen.IsEnabled = _settings.Shell != Shell.RunCommand;
            };
        }
    }
}
