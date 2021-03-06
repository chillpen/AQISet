﻿using System;
using System.Collections.Generic;
using AQI;
using AQI.Abstract;
using AQI.Exception;

namespace typhoon.Api.Auto
{
    public class TyphoonList_Auto : AParamSrcUrl
    {

        #region 静态变量

        private static string tag = "TyphoonList_Auto";
        private static string name = "浙江台风历史";
        private static string url = "http://typhoon.zjwater.gov.cn/Api/TyphoonList";
        private static AqiConstant.SourceUpdataInterval sui = AqiConstant.SourceUpdataInterval.HOUR;
        private static List<string> pn = new List<string>(){
            "boundsParams.", ".yearStart", ".yearEnd"
        };
        private static AqiConstant.ParamSendType ps = AqiConstant.ParamSendType.GET;
        private static new AqiConstant.ParamFilterType pft = AqiConstant.ParamFilterType.OnceAgain;
        private static new AqiConstant.ParamUrlType put = AqiConstant.ParamUrlType.PATH;

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
        public override AqiConstant.SourceUpdataInterval SUI
        {
            get
            {
                return sui;
            }
        }
        public override List<string> ParamName
        {
            get
            {
                return pn;
            }
        }
        public override AqiConstant.ParamSendType ParamSendType
        {
            get
            {
                return ps;
            }
        }
        public override AqiConstant.ParamUrlType ParamUrlType
        {
            get
            {
                return put;
            }
        }
        public override AqiConstant.ParamFilterType ParamFilterType
        {
            get
            {
                return pft;
            }
        }

        #endregion

        #region 内部方法

        /// <summary>
        /// 加载boundsParams用于计算
        /// </summary>
        /// <returns></returns>
        private List<AqiParam> loadBoundsParams()
        {
            List<AqiParam> apList = new List<AqiParam>();
            //扩展参数
            List<AqiParam> apListTemp = AqiParam.CreateListFormJson(this, this.Tag, "boundsParams");

            //根据 扩展参数 生成最终参数
            foreach (AqiParam apTemp in apListTemp)
            {
                int yearS = DateTime.Now.Year;
                int yearE = DateTime.Now.Year;
                if (apTemp.ContainsKey("yearStart"))
                {
                    yearS = Int32.Parse(apTemp["yearStart"]);
                }
                if (apTemp.ContainsKey("yearEnd"))
                {
                    yearE = Int32.Parse(apTemp["yearEnd"]);
                }

                if (yearS > yearE)
                {
                    //错误
                    throw new ParamException("开始年份大于结束年份");
                }

                for (int year = yearS; year <= yearE; year++)
                {
                    AqiParam ap = new AqiParam(apTemp.Name + "\\" + year.ToString());
                    ap.Group = apTemp.Group;
                    ap.Add("", year.ToString());
                    apList.Add(ap);
                }
            }

            return apList;
        }

        #endregion

        #region 重写方法

        /// <summary>
        /// 加载参数
        ///     读取JSON中的boundsParams字段
        /// </summary>
        /// <returns></returns>
        public override bool LoadParams()
        {
            this.listParamCache = this.loadBoundsParams();
            this.dtParamCacheTime = AqiParam.ReadWriteTimeFormJson(this);

            return true;
        }

        #endregion

    }
}
