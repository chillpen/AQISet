﻿using System;
using AQI.Abstract;
using sxAQIWeb.Abstract;

namespace sxAQIWeb.Station
{
    public class yanglingND : sxAQIWebSrcUrl
    {

        #region 静态变量

        private static string tag = "yanglingND";
        private static string name = "杨凌市站点1小时浓度";
        private static string url = "http://113.140.66.226:8024/sxAQIWeb/swfPage/yanglingND.xml";
        private static AQI.AqiConstant.SourceUpdataInterval sui = AQI.AqiConstant.SourceUpdataInterval.HOUR;

        #endregion

        #region 属性

        public override string Tag
        {
            get
            {
                return tag;
            }
        }
        public override string Name
        {
            get
            {
                return name;
            }
        }
        public override string Url
        {
            get
            {
                return url;
            }
        }
        public override AQI.AqiConstant.SourceUpdataInterval SUI
        {
            get
            {
                return sui;
            }
        }

        #endregion

    }
}
