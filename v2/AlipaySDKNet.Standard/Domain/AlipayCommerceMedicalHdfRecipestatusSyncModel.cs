using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfRecipestatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfRecipestatusSyncModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 支付宝跳转链接
        /// </summary>
        [XmlElement("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 阿福跳转链接
        /// </summary>
        [XmlElement("aq_url")]
        public string AqUrl { get; set; }

        /// <summary>
        /// 状态变更时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 处方ID
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 云配药记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 报到单ID
        /// </summary>
        [XmlElement("signin_form_id")]
        public string SigninFormId { get; set; }

        /// <summary>
        /// 变更后的状态值
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
