using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppInstotherconfigUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppInstotherconfigUseModel : AopObject
    {
        /// <summary>
        /// 一级业务，新增的时候必传。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构，新增的时候必传，如果配置销账机构维度此字段设置为(ALL)。
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构，新增的时候必传。
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 新增的时候必传。 支持类型列表 BILLKEY_FIND_TIPS：查找户号电话信息；PAY_RULE：缴费规则； INST_COVERAGE_AREA 机构覆盖区域
        /// </summary>
        [XmlElement("config_type")]
        public string ConfigType { get; set; }

        /// <summary>
        /// 配置内容, json格式
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 分页查询的时候当前页数，默认第一页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 主键，修改的时候必传。
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 操作类型  增删改查  （add，delete，update，select）
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 分页查询的时候单页最大个数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// PRE/ONLINE 增加的时候必传
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级业务，新增的时候必传。
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
