using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageConsultResult Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageConsultResult : AopObject
    {
        /// <summary>
        /// 券包购买咨询结果code： SUCCESS：可以领取； PRODUCT_NOT_ENABLE：产品不可用； NOT_IN_SELL_TIME：不在销售时间内； PRODUCT_SOLD_OUT：产品售罄； USER_PURCHASE_LIMIT：用户购买上限； OTHER：不可购买，未知原因
        /// </summary>
        [XmlElement("consult_result_code")]
        public string ConsultResultCode { get; set; }

        /// <summary>
        /// 券包id
        /// </summary>
        [XmlElement("voucher_package_id")]
        public string VoucherPackageId { get; set; }
    }
}
