using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageOrderModel : AopObject
    {
        /// <summary>
        /// 续约时长数量，其单位依赖于duration_unit表示的单位类型，如 duration_unit=HALF_YEAR，duration_quantity=3 则表示一年半
        /// </summary>
        [XmlElement("duration_quantity")]
        public long DurationQuantity { get; set; }

        /// <summary>
        /// 购买会员包的时长单位(目前支持HALF_YEAR半年和YEAR年两个选项)，生效与本结构的购买数量(duration_quantity)结合使用，如购买3个HALF_YEAR表示一年半。
        /// </summary>
        [XmlElement("duration_unit")]
        public string DurationUnit { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("exclude_license_list")]
        [XmlArrayItem("string")]
        public List<string> ExcludeLicenseList { get; set; }

        /// <summary>
        /// 需要小于或者等于当前权益包的license数量，例如现在有15个license，有3个不需要续约，则需要传入12，同时在exclude_license_list指定不续约的license
        /// </summary>
        [XmlElement("license_num")]
        public long LicenseNum { get; set; }

        /// <summary>
        /// 订单编号，是指伙伴的正式向企信提交订单后，拿到的一个唯一的不重复订单号，届时伙伴的财务打款时需要附上该订单号，方便做资金流和订单的匹配
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务ID,在调用本接口中需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 会员包编码
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
