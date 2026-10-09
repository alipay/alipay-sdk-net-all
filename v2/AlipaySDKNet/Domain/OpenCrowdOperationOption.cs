using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCrowdOperationOption Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCrowdOperationOption : AopObject
    {
        /// <summary>
        /// 每个圈选标签有一个或者多个圈选项，每个圈选项在创建圈选请求时都需要传入圈选值
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// SINGLE_SELECT：当前圈选项只支持1个圈选值，传入标签详情查询返回的圈选值ID MULTI_SELECT：当前圈选项支持多个圈选值，传入标签详情查询返回的圈选值ID INPUT_VALUE：自定义输入圈选值 NUMBER_RANGE_VALUE：圈选值为数值范围类型，目前支持介于、大于、大于等于、小于、小于等于几种模式。
        /// </summary>
        [XmlElement("option_data_type")]
        public string OptionDataType { get; set; }

        /// <summary>
        /// 当前圈选项下的全部圈选值
        /// </summary>
        [XmlArray("option_list")]
        [XmlArrayItem("open_operation_option")]
        public List<OpenOperationOption> OptionList { get; set; }

        /// <summary>
        /// 标签圈选项的中文名称
        /// </summary>
        [XmlElement("option_name")]
        public string OptionName { get; set; }
    }
}
