using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCrowdOperationOptionRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCrowdOperationOptionRequest : AopObject
    {
        /// <summary>
        /// 当前圈选项数据类型为「NUMBER_RANGE_VALUE 数值范围类型」，需要单独传入圈选范围值。 不需要传入具体数值单位，如果是金额数值范围，传入金额范围单位是「元」。
        /// </summary>
        [XmlElement("number_range_option_value")]
        public OpenNumberRangeValue NumberRangeOptionValue { get; set; }

        /// <summary>
        /// 每个圈选标签有一个或者多个圈选项，每个圈选项在创建圈选请求时都需要传入圈选值
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 标签圈选请求中，当前圈选项的圈选值ID，如果圈选项的数据类型为「MULTI_SELECT」代表支持多个圈选值ID，用逗号分割，其他数据类型只支持传入1个圈选值ID
        /// </summary>
        [XmlElement("option_value_id_list")]
        public string OptionValueIdList { get; set; }

        /// <summary>
        /// 标签圈选请求中，当前圈选项的圈选值，如果圈选项的数据类型为「MULTI_SELECT」代表支持多个圈选值，用逗号分割，其他数据类型只支持传入1个圈选值
        /// </summary>
        [XmlElement("option_value_list")]
        public string OptionValueList { get; set; }
    }
}
