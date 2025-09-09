using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderStatusSyncConfirmationInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderStatusSyncConfirmationInfoDTO : AopObject
    {
        /// <summary>
        /// 当推送确认状态时，可传酒店确认号
        /// </summary>
        [XmlElement("confirm_num")]
        public string ConfirmNum { get; set; }

        /// <summary>
        /// 已确认:CONFIRMED 确认失败：CONFIRMED_FAIL
        /// </summary>
        [XmlElement("confirm_result")]
        public string ConfirmResult { get; set; }

        /// <summary>
        /// INFO_ERROR：预订信息错误（入住日期、个人信息等） PRODUCT_DISAVAILBILE:产品下架不可用 FULLY_BOOKED:满房 PRICE_CHANGED:变价 OTHER：其他
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 确认失败或酒店服务商发起取消原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 售卖房型是否为“立即确认”房型：True-是；False-否；
        /// </summary>
        [XmlElement("instant_confirm")]
        public bool InstantConfirm { get; set; }
    }
}
