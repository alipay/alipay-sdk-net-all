using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOQuitConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOQuitConfig : AopObject
    {
        /// <summary>
        /// 退出提示
        /// </summary>
        [XmlElement("quit_desc")]
        public string QuitDesc { get; set; }

        /// <summary>
        /// 退出跳转商家页地址，当quit_type取值为：QUIT_MERCHANT_JUMP，必传
        /// </summary>
        [XmlElement("quit_jump_url")]
        public string QuitJumpUrl { get; set; }

        /// <summary>
        /// 退出芝麻GO方式，取值：   （1）QUIT_COMMON("QUIT_COMMON", "标准退出"), （2）QUIT_MERCHANT_JUMP("QUIT_MERCHANT_JUMP", "商家页退出"), （3）QUIT_ONLY_TIPS("QUIT_ONLY_TIPS", "仅退出提示")
        /// </summary>
        [XmlElement("quit_type")]
        public string QuitType { get; set; }
    }
}
