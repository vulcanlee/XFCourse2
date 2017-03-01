using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFStartPrism.ViewModels
{

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region 是否忙碌中
        private bool _是否忙碌中;
        /// <summary>
        /// 是否忙碌中
        /// </summary>
        public bool 是否忙碌中
        {
            get { return this._是否忙碌中; }
            set { this.SetProperty(ref this._是否忙碌中, value); }
        }
        #endregion

        #region 顯示進度棒
        private bool _顯示進度棒;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public bool 顯示進度棒
        {
            get { return this._顯示進度棒; }
            set { this.SetProperty(ref this._顯示進度棒, value); }
        }
        #endregion

        #region 處理進度值
        private double _處理進度值;
        /// <summary>
        /// 處理進度值
        /// </summary>
        public double 處理進度值
        {
            get { return this._處理進度值; }
            set { this.SetProperty(ref this._處理進度值, value); }
        }
        #endregion

        #region 處理進度說明文字
        private string _處理進度說明文字;
        /// <summary>
        /// 處理進度說明文字
        /// </summary>
        public string 處理進度說明文字
        {
            get { return this._處理進度說明文字; }
            set { this.SetProperty(ref this._處理進度說明文字, value); }
        }
        #endregion

        #region 顯示處理進度說明文字
        private bool _顯示處理進度說明文字;
        /// <summary>
        /// 顯示處理進度說明文字
        /// </summary>
        public bool 顯示處理進度說明文字
        {
            get { return this._顯示處理進度說明文字; }
            set { this.SetProperty(ref this._顯示處理進度說明文字, value); }
        }
        #endregion

        #region 處理進度說明文字大小
        private double _處理進度說明文字大小;
        /// <summary>
        /// 處理進度說明文字大小
        /// </summary>
        public double 處理進度說明文字大小
        {
            get { return this._處理進度說明文字大小; }
            set { this.SetProperty(ref this._處理進度說明文字大小, value); }
        }
        #endregion

        #region 處理進度說明文字顏色
        private Color _處理進度說明文字顏色;
        /// <summary>
        /// 處理進度說明文字顏色
        /// </summary>
        public Color 處理進度說明文字顏色
        {
            get { return this._處理進度說明文字顏色; }
            set { this.SetProperty(ref this._處理進度說明文字顏色, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        public DelegateCommand 啟動Command { get; set; }

        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            #region 相依性服務注入的物件

            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令
            啟動Command = new DelegateCommand(async () =>
            {
                #region 啟動正在忙碌中的控制項動畫與顯示相關處理狀況訊息的控制項
                是否忙碌中 = true;
                顯示進度棒 = true;
                顯示處理進度說明文字 = true;
                #endregion

                #region 第一階段處理工作
                for (int i = 0; i < 70; i++)
                {
                    處理進度值 = i / 100.0;
                    // 等候一段時間，模擬正在處理工作
                    // 在此使用 TAP 方式，使用者螢幕與UI，不會被凍結
                    await Task.Delay(70);
                    處理進度說明文字 = $"忙碌中，請稍後 {i}%";
                }
                #endregion

                #region 第二階段處理工作
                for (int i = 71; i < 101; i++)
                {
                    處理進度值 = i / 100.0;
                    // 在此使用 TAP 方式，使用者螢幕與UI，不會被凍結
                    await Task.Delay(200);
                    處理進度說明文字 = $"忙碌中，請稍後 {i}%";
                }
                #endregion

                #region 關閉正在忙碌中的控制項動畫，隱藏不需要的控制項和調整控制項樣貌
                是否忙碌中 = false;
                顯示進度棒 = false;
                處理進度說明文字 = $"指定工作已經完成";
                處理進度說明文字大小 = 28;
                處理進度說明文字顏色 = Color.Pink;
                #endregion
            });
            #endregion

            #region 事件聚合器訂閱

            #endregion
        }

        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            await ViewModelInit();
        }
        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法

        /// <summary>
        /// ViewModel 資料初始化
        /// </summary>
        /// <returns></returns>
        private async Task ViewModelInit()
        {
            處理進度說明文字 = "";
            處理進度說明文字大小 = 20;
            處理進度說明文字顏色 = Color.White;
            await Task.Delay(100);
        }
        #endregion

    }
}
