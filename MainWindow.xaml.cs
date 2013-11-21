using System;
using System.Windows;

namespace WpfApplication1
{
  /// <summary>
  /// MainWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class MainWindow : Window
  {
    private readonly MainWindowViewModel vm;

    public MainWindow()
    {
      InitializeComponent();

      vm = DataContext as MainWindowViewModel;
      WeakEventManager<MainWindowViewModel, EventArgs>.AddHandler(vm, "Hide", (sender, e) => this.Hide());
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      vm.HideWindow();
    }
  }
}
