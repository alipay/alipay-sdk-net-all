using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GreenAction Data Structure.
    /// </summary>
    [Serializable]
    public class GreenAction : AopObject
    {
        /// <summary>
        /// 不同的绿色行为的业务值描述，比如用户回收1000g废纸，即传入1000，具体生成能量信息由森林侧计算生成
        /// </summary>
        [XmlElement("biz_value")]
        public long BizValue { get; set; }

        /// <summary>
        /// 由绿色开放平台为每一种绿色行为定义的能量场景二级类目编码
        /// </summary>
        [XmlElement("second_scene")]
        public string SecondScene { get; set; }
    }
}
