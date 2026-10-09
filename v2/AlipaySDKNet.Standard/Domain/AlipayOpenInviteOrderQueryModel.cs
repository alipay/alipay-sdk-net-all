using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInviteOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInviteOrderQueryModel : AopObject
    {
        /// <summary>
        /// 商家的支付宝账号，如果调用alipay.open.invite.order.create接口时有传入支付宝账号，则这里查询签约状态时必须要传
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// isv业务系统单据编号
        /// </summary>
        [XmlElement("isv_biz_id")]
        public string IsvBizId { get; set; }
    }
}
