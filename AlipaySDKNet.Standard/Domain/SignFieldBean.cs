using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignFieldBean Data Structure.
    /// </summary>
    [Serializable]
    public class SignFieldBean : AopObject
    {
        /// <summary>
        /// 签署类型：  platform-平台自动签：无需指定签署人。创建流程后，系统将自动盖上商户的默认企业印章。  person-个人签署：需要指定签署人个人信息。创建流程后，需通过签署插件完成签署。 org-企业签署：需要指定签署企业信息与经办人个人信息。创建流程后，需经办人代企业完成签署。（企业暂不支持插件签署，可通过获取签署地址接口获取企业签署地址）
        /// </summary>
        [XmlElement("sign_field_type")]
        public string SignFieldType { get; set; }

        /// <summary>
        /// 签署人信息
        /// </summary>
        [XmlElement("signer")]
        public SignerBean Signer { get; set; }

        /// <summary>
        /// 签署区key值
        /// </summary>
        [XmlElement("struct_key")]
        public string StructKey { get; set; }
    }
}
