using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CareerOpenBaseIntentionLadarDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class CareerOpenBaseIntentionLadarDetailResult : AopObject
    {
        /// <summary>
        /// 业务描述信息
        /// </summary>
        [XmlElement("desc_msg")]
        public string DescMsg { get; set; }

        /// <summary>
        /// 业务明细状态
        /// </summary>
        [XmlElement("detail_status")]
        public string DetailStatus { get; set; }

        /// <summary>
        /// 使用SM4算法加密后的身份证号密文
        /// </summary>
        [XmlElement("encrypted_id_card")]
        public string EncryptedIdCard { get; set; }

        /// <summary>
        /// 使用SM4算法加密后的手机号密文
        /// </summary>
        [XmlElement("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 广告标识符（IDFA），iOS 设备用于广告归因的匿名设备标识。
        /// </summary>
        [XmlElement("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// 国际移动设备识别码（IMEI），用于标识具备蜂窝通信能力的移动设备。
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 开放匿名设备标识符（OAID），Android 设备用于广告归因的匿名设备标识。
        /// </summary>
        [XmlElement("oaid")]
        public string Oaid { get; set; }

        /// <summary>
        /// 调用方提供的外部业务号，长度为1至64位，仅支持英文字母和数字；需要保持业务号的唯一性，相同 out_biz_no 重复提交会被拒绝，整批申请不予受理
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 意向雷达返回的业务评分，百分制（0-100）
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
