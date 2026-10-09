using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasAccountAppliedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasAccountAppliedSyncModel : AopObject
    {
        /// <summary>
        /// 标识用户活动数据的唯一id
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("gmt_applied")]
        public string GmtApplied { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
