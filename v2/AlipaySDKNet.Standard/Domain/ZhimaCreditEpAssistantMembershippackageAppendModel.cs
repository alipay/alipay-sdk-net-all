using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageAppendModel : AopObject
    {
        /// <summary>
        /// 在当前会员包中增购的license数量
        /// </summary>
        [XmlElement("license_num")]
        public long LicenseNum { get; set; }

        /// <summary>
        /// 订单编号，是指伙伴的正式向企信提交订单后，拿到的一个唯一的不重复订单号，届时伙伴的财务同学打款时需要附上该订单号，方便做资金流和订单的匹配
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务ID,在调用本接口中需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 创建会员包返回的会员包编码
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
