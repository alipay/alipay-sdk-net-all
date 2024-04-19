using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuntimeProtectConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RuntimeProtectConfig : AopObject
    {
        /// <summary>
        /// 防调试,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_debug")]
        public long AntiDebug { get; set; }

        /// <summary>
        /// 模拟器检查,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_emulator")]
        public long AntiEmulator { get; set; }

        /// <summary>
        /// 防hook,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_hook")]
        public long AntiHook { get; set; }

        /// <summary>
        /// 防注入,防内存dump,防内存数据修改、读取,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_inject")]
        public long AntiInject { get; set; }

        /// <summary>
        /// 防多开软件运行,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_multi_app")]
        public long AntiMultiApp { get; set; }

        /// <summary>
        /// 防root,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_root")]
        public long AntiRoot { get; set; }

        /// <summary>
        /// 重打包,签名校验,AndroidManifest防篡改,签名文件保护,0为检测到风险退出，1不处理
        /// </summary>
        [XmlElement("anti_signature")]
        public long AntiSignature { get; set; }
    }
}
