using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFStart1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void button_Clicked(object sender, EventArgs e)
        {
            #region 啟動正在忙碌中的控制項動畫與顯示相關處理狀況訊息的控制項
            activityIndicator.IsRunning = true;
            progressBar.IsVisible = true;
            label.IsVisible = true;
            #endregion

            #region 第一階段處理工作
            for (int i = 0; i < 70; i++)
            {
                progressBar.Progress = i / 100.0;
                // 等候一段時間，模擬正在處理工作
                // 在此使用 TAP 方式，使用者螢幕與UI，不會被凍結
                await Task.Delay(70);
                label.Text = $"忙碌中，請稍後 {i}%";
            }
            #endregion

            #region 第二階段處理工作
            for (int i = 71; i < 101; i++)
            {
                progressBar.Progress = i / 100.0;
                // 在此使用 TAP 方式，使用者螢幕與UI，不會被凍結
                await Task.Delay(200);
                label.Text = $"忙碌中，請稍後 {i}%";
            }
            #endregion

            #region 關閉正在忙碌中的控制項動畫，隱藏不需要的控制項和調整控制項樣貌
            activityIndicator.IsRunning = false;
            progressBar.IsVisible = false;
            label.Text = $"指定工作已經完成";
            label.FontSize = 28;
            label.TextColor = Color.Pink;
            #endregion
        }
    }
}
