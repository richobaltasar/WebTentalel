using System.Collections.Generic;

namespace WebTentakel.Models
{
    public static class General
    {
        public static string Configuration { get; set; }

    }
    public class landingPageModel
    {
        public List<HomeBannerData> Home { get; set; }
        public ServicesModel Services { get; set; }
    }

    public class ServicesModel
    {
        public List<ServicesData> Listdata { get; set; }
    }
    public class ServicesData
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
    }

    public class ContentSliderModel
    {
        public List<ContentSliderData> Listdata { get; set; }
    }
    public class ContentSliderData
    {
        public string bg_img { get; set; }
        public string left1_text { get; set; }
        public string left2_text { get; set; }
        public string left_btn { get; set; }

        public string right_text { get; set; }
        public string right_img { get; set; }
    }

    #region "Home Banner"
    public class HomeBannerModel
    {
        public List<HomeBannerData> ListBanner { get; set; }
    }
    public class HomeBannerData
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string Button { get; set; }
    }
    #endregion

}
