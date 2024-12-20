using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobPayslipInitializeModel : AopObject
    {
        /// <summary>
        /// 支付宝登录账号：手机号或者邮箱
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 授权成功后回调地址；授权成功后，回调地址会拼接上用户参数及token信息一起返回，用户参数可为alipay_login_id、user_id、open_id、out_biz_no任一种；链接中拼接参数：alipayLoginId、userId、openId、userName、bizNo(必有)、outBizNo；其中oepnId和userId任意一个不为空，都会返回openId和userId；以out_biz_no入参为例，回调成功示例如下：alipays://platformapi/startapp?appId=2021003160674131&query=userName%3Dxxxx%26outBizNo%3D20241211000004%26bizNo%3D212529c081e522543da9450c84dd747b
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
