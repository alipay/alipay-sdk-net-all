using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialOpengreenEnergySendResponse.
    /// </summary>
    public class AlipaySocialOpengreenEnergySendResponse : AopResponse
    {
        /// <summary>
        /// 是否所有行为能量都发放成功了
        /// </summary>
        [XmlElement("all_success")]
        public bool AllSuccess { get; set; }

        /// <summary>
        /// 能量生成失败的信息，当某一个行为不能产生能量的时候会返回不能产生的原因，对于描述信息可参考接口文档信息
        /// </summary>
        [XmlElement("energy_generate_error_code")]
        public string EnergyGenerateErrorCode { get; set; }

        /// <summary>
        /// 能量产生结果，根据入参传入绿色行为的个数返回每一个绿色行为产生的结果，可能为空，代表对应行为未产生能量，未产生能量的原因请参考错误码信息
        /// </summary>
        [XmlElement("energy_generate_info")]
        public string EnergyGenerateInfo { get; set; }
    }
}
