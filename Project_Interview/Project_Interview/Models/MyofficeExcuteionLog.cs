﻿using System;
using System.Collections.Generic;

namespace Project_Interview.Models;

public partial class MyofficeExcuteionLog
{
    /// <summary>
    /// 自訂索引碼
    /// </summary>
    public int DeLogAuthId { get; set; }

    /// <summary>
    /// 預存程序名稱
    /// </summary>
    public string? DeLogStoredPrograms { get; set; }

    /// <summary>
    /// 執行的群組代碼
    /// </summary>
    public Guid? DeLogGroupId { get; set; }

    /// <summary>
    /// 是否認定為 Bug
    /// </summary>
    public bool? DeLogIsCustomDebug { get; set; }

    /// <summary>
    /// 執行的項目
    /// </summary>
    public string? DeLogExecutionProgram { get; set; }

    /// <summary>
    /// 執行的內容或是說明
    /// </summary>
    public string? DeLogExecuteionInfo { get; set; }

    /// <summary>
    /// 此錯誤是否要進行檢查
    /// </summary>
    public bool? DeLogVerifyNeeded { get; set; }

    /// <summary>
    /// 新增日期
    /// </summary>
    public DateTime? ExelogNowdatetime { get; set; }
}
