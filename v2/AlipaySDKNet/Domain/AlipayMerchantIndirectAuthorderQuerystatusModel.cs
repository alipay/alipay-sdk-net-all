using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectAuthorderQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectAuthorderQuerystatusModel : AopObject
    {
        /// <summary>
        /// 商家认证申请单号，参数二选一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务号，参数二选一，业务自定义，保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 1. 收单机构调用API提交申请单时，可选择是否指定单个服务商范围。非收单机构无需填写此字段。 2. 此字段填写单个服务商pid信息：填写（即：单服务商提交认证方式），查询申请单返回的认证二维码qr_code和填写服务商对应，仅能认证填写服务商下的商户；不填写（即：全服务商提交认证方式），查询申请单返回的认证二维码qr_code和收单机构对应，可认证收单机构下全部商户。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
