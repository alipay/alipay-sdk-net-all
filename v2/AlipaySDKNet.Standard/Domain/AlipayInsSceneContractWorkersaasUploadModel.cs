using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneContractWorkersaasUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneContractWorkersaasUploadModel : AopObject
    {
        /// <summary>
        /// 灵工协议文件列表。
        /// </summary>
        [XmlElement("files")]
        public string Files { get; set; }

        /// <summary>
        /// 签约人身份证号。取签约人的身份证号。
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 业务透传参数。原值传递。
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 签约人手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 签约人真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 灵工协议签约订单号。取值为灵工签约订单号。
        /// </summary>
        [XmlElement("sign_order_no")]
        public string SignOrderNo { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }
    }
}
