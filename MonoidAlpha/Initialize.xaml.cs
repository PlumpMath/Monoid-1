using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonoidAlpha
{
	/// <summary>
	/// Initialize.xaml 的交互逻辑
	/// </summary>
	public partial class Initialize : Page
	{
		public Initialize()
		{
			InitializeComponent();
		}
		private void BtnStartGameEntered(object sender, MouseEventArgs e)
		{
			BtnStartGame.Foreground = (Brush)FindResource("BrushTextActive");
		}

		private void BtnStartGameLeft(object sender, MouseEventArgs e)
		{
			BtnStartGame.Foreground = (Brush)FindResource("BrushText");
		}

		private void BtnStartGameClicked(object sender, RoutedEventArgs e)
		{
			//TODO: 新建一个游戏开始嗨啊
		}

		private void BtnLoadGameClicked(object sender, RoutedEventArgs e)
		{
			throw new NotImplementedException();
			//TODO: 做个加载游戏的机制
		}

		private void BtnLoadGameEntered(object sender, MouseEventArgs e)
		{
			BtnLoadGame.Foreground = (Brush)FindResource("BrushTextActive");
		}

		private void BtnLoadGameLeft(object sender, MouseEventArgs e)
		{
			BtnLoadGame.Foreground = (Brush)FindResource("BrushText");
		}
	}
}
