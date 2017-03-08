using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace XFListViewOpenData.ViewModels
{

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)
        #region 營建署所屬景點活動清單
        //你可以在這裡做物件初始化或者在建構式中處理
        private ObservableCollection<營建署所屬景點活動> _營建署所屬景點活動清單 = new ObservableCollection<營建署所屬景點活動>();
        /// <summary>
        /// 營建署所屬景點活動清單
        /// </summary>
        public ObservableCollection<營建署所屬景點活動> 營建署所屬景點活動清單
        {
            get { return _營建署所屬景點活動清單; }
            set { SetProperty(ref _營建署所屬景點活動清單, value); }
        }
        #endregion

        #endregion

        #region Field 欄位

        private readonly INavigationService _navigationService;
        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            #region 相依性服務注入的物件

            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令

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
            // 這段程式碼為何不寫在建構式中
            #region 讀取網路上最新資料清單，並且顯示在螢幕上
            營建署所屬景點活動清單.Clear();

            // 這裡需要加入 Microsoft.Net.Http & Newtonsoft.Json 兩個 NuGet 套件

            using (HttpClient client = new HttpClient())
            {
                // 使用非同步方式呼叫，並免應用程式畫面凍結
                var fooReslut = await client.GetStringAsync("http://data.gov.tw/iisi/logaccess/37612?dataUrl=http://data.moi.gov.tw/MoiOD/System/DownloadFile.aspx?DATA=D768074E-932A-4670-B908-0BE1402A7662&ndctype=JSON&ndcnid=7509");

                var foo營建署所屬景點活動s = JsonConvert.DeserializeObject<List<營建署所屬景點活動>>(fooReslut);
                foreach (var item in foo營建署所屬景點活動s)
                {
                    營建署所屬景點活動清單.Add(item);
                }
            }
            #endregion
        }
        #endregion

    }

    /// <summary>
    /// 將 Json 內容複製到剪貼簿上，使用 編輯 > 選擇性貼上 > 貼上 JSON 作為類別
    /// </summary>
    public class 營建署所屬景點活動
    {
        public string id { get; set; }
        public string orgname { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string extraurl { get; set; }
        public string created { get; set; }
        public string introtext { get; set; }
    }

}
