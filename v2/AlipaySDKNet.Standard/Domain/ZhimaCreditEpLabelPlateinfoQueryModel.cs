using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpLabelPlateinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpLabelPlateinfoQueryModel : AopObject
    {
        /// <summary>
        /// 实力标牌内部单号+唯一+查询实力标牌高清图片+小程序跳转时带出
        /// </summary>
        [XmlElement("plate_biz_no")]
        public string PlateBizNo { get; set; }
    }
}
