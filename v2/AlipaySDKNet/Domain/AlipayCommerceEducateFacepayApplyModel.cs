using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacepayApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacepayApplyModel : AopObject
    {
        /// <summary>
        /// 扩展信息，json格式。 例如： ● 默认不传，兜底为{"useBankChannel":"YES","useBankMode":"BANK"} ● 不使用银行代扣, {"useBankChannel":"NO"} ● 使用银行代扣且指定银行(parentPhone/openAssetRole/cardHolderName可选，建议提供)，{"useBankChannel":"YES","useBankMode":"BANK","parentPhone":"13212345678","openAssetRole":"CHILD","cardHolderName":"张三"}  ● 使用银行代扣且指定银行卡(parentPhone/openAssetRole/cardHolderName可选，建议提供)，{"useBankChannel":"YES","useBankMode":"BANK_CARD","cardNo":"4340627330268609","parentPhone":"13212345678","openAssetRole":"CHILD","cardHolderName":"张三"} ● 使用银行代扣且指定数币，{"useBankChannel":"YES","useBankMode":"DCEP"} ● 使用银行代扣且指定数币编号，{"useBankChannel":"YES","useBankMode":"DCEP_CARD","cardNo":"00123445678951302"}。 ● 使用银行代扣切指定BIN（cardNo为银行识别码；openAssetRole为开通资产角色，可选的有「CHILD：孩子，PARENT：家长」；【可选】cardHolderName为持卡人姓名），{"useBankChannel":"YES","useBankMode":"BIN","cardNo":"123456","openAssetRole":"CHILD","cardHolderName":"张三"} 如果指定银行卡但未提供cardNo，必须实现获取银行卡信息的SPIAPI。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 刷脸用户openId
        /// </summary>
        [XmlElement("face_open_id")]
        public string FaceOpenId { get; set; }

        /// <summary>
        /// 刷脸用户id
        /// </summary>
        [XmlElement("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 接入场景，可选项： K12   --  K12场景 COLLEGE  --  高校场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
