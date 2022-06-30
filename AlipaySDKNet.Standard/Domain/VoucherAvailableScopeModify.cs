using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableScopeModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableScopeModify : AopObject
    {
        /// <summary>
        /// 可用范围修改类型。 ADD:增加可用范围 REMOVE:减少可用范围 MODIFY_ALL:修改全量可用范围
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 可用城市修改信息。 注意: 与modify_type结合使用,modify_type=ADD时只需传入需要增加的城市
        /// </summary>
        [XmlElement("order_voucher_available_city_code")]
        public OrderVoucherAvailableCityCodeModify OrderVoucherAvailableCityCode { get; set; }

        /// <summary>
        /// 可用门店修改信息。 注意: 1.与modify_type结合使用,modify_type=ADD时只需传入需要增加的门店。 2.门店修改支持部分成功，商户可根据返回结果调整失败的门店信息，调整后再修改。
        /// </summary>
        [XmlElement("order_voucher_available_shop")]
        public OrderVoucherAvailableShopModify OrderVoucherAvailableShop { get; set; }
    }
}
