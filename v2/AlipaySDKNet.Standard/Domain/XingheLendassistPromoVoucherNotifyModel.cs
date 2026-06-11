using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistPromoVoucherNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistPromoVoucherNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("cust_name")]
        public string CustName { get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 机构代码（开放平台appId）
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 机构券信息 JSON 格式字符串
        /// </summary>
        [XmlElement("inst_voucher_info")]
        public string InstVoucherInfo { get; set; }

        /// <summary>
        /// 通知类型，券领取通知（固定）：INST_VOUCHER_RECEIVE
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
