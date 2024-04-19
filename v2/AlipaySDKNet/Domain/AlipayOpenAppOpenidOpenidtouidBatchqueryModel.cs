using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidOpenidtouidBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidOpenidtouidBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务appid参数，用于转换其他appid的openid，需要申请更高执行权限。默认应为空。
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 待查询转换的openid列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }
    }
}
