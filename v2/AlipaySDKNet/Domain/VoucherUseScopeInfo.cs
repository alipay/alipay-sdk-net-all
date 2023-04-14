using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseScopeInfo : AopObject
    {
        /// <summary>
        /// 小程序appid列表
        /// </summary>
        [XmlArray("app_id_list")]
        [XmlArrayItem("string")]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// 商户pid列表
        /// </summary>
        [XmlArray("pid_list")]
        [XmlArrayItem("string")]
        public List<string> PidList { get; set; }

        /// <summary>
        /// 支付宝门店id列表
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
