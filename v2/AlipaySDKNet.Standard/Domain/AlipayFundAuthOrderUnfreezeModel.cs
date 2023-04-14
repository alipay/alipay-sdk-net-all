using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthOrderUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthOrderUnfreezeModel : AopObject
    {
        /// <summary>
        /// 本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号。
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 解冻扩展信息。map<string, string>的json格式，目前支持如下key： unfreezeBizInfo：由芝麻消费，当前支持value如下： "bizComplete":"true"——标识本次解冻用户已履约，true表示信用单履约完结
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 解冻请求流水号。 如果是针对同一笔授权单不同的解冻请求，如第一次解冻1元，第二次解冻2元，则解冻请求流水号必须不重复； 如果是针对同一笔解冻请求的多次发起，则需要保证每次发起，解冻请求流水号和解冻金额都相同
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次解冻操作的附言描述
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
