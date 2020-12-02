using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneYebAssetTradeUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneYebAssetTradeUnfreezeModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 冻结码
        /// </summary>
        [XmlElement("freeze_code")]
        public string FreezeCode { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
