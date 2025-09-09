using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenOperationOption Data Structure.
    /// </summary>
    [Serializable]
    public class OpenOperationOption : AopObject
    {
        /// <summary>
        /// 标签圈选值的描述性信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 标签圈选值ID，创建标签圈选人群时需要传入对应圈选值的ID。
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 如果标签圈选值为树形结构，例如「预测地域分布」的标签值「地域树」，返回当前值的父值ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 如果标签圈选值为树形结构，例如「预测地域分布」的标签值「地域树」，返回当前值的父值
        /// </summary>
        [XmlElement("parent_value")]
        public string ParentValue { get; set; }

        /// <summary>
        /// 标签圈选的展示标题
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 标签圈选需要传入的实际圈选值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
