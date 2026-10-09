using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassaccountNamehashModifyResponse.
    /// </summary>
    public class AnttechOceanbasePassaccountNamehashModifyResponse : AopResponse
    {
        /// <summary>
        /// 实际更新行数
        /// </summary>
        [XmlElement("affected_rows")]
        public long AffectedRows { get; set; }

        /// <summary>
        /// 是否全部通过检查
        /// </summary>
        [XmlElement("can_execute")]
        public bool CanExecute { get; set; }

        /// <summary>
        /// 冲突数量
        /// </summary>
        [XmlElement("conflict_count")]
        public long ConflictCount { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 账号处理内容
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("pass_account_name_hash_record_d_t_o")]
        public List<PassAccountNameHashRecordDTO> Items { get; set; }

        /// <summary>
        /// 是否预检
        /// </summary>
        [XmlElement("precheck")]
        public bool Precheck { get; set; }

        /// <summary>
        /// 检查通过数量
        /// </summary>
        [XmlElement("ready_count")]
        public long ReadyCount { get; set; }

        /// <summary>
        /// 选中数量
        /// </summary>
        [XmlElement("selected_count")]
        public long SelectedCount { get; set; }

        /// <summary>
        /// 快照令牌
        /// </summary>
        [XmlElement("snapshot_token")]
        public string SnapshotToken { get; set; }
    }
}
