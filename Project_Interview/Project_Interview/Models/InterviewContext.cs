﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project_Interview.Models;

public partial class InterviewContext : DbContext
{
    public InterviewContext()
    {
    }

    public InterviewContext(DbContextOptions<InterviewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MyofficeAcpd> MyofficeAcpds { get; set; }

    public virtual DbSet<MyofficeExcuteionLog> MyofficeExcuteionLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MyofficeAcpd>(entity =>
        {
            entity.HasKey(e => e.AcpdSid);

            entity.ToTable("Myoffice_ACPD");

            entity.Property(e => e.AcpdSid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("使用者主鍵")
                .HasColumnName("acpd_sid");
            entity.Property(e => e.AcpdCname)
                .HasMaxLength(60)
                .HasComment("中文名稱")
                .HasColumnName("acpd_cname");
            entity.Property(e => e.AcpdEmail)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("使用者信箱")
                .HasColumnName("acpd_email");
            entity.Property(e => e.AcpdEname)
                .HasMaxLength(40)
                .HasComment("英文名稱")
                .HasColumnName("acpd_ename");
            entity.Property(e => e.AcpdLoginId)
                .HasMaxLength(30)
                .HasComment("登入帳號")
                .HasColumnName("acpd_LoginID");
            entity.Property(e => e.AcpdLoginPw)
                .HasMaxLength(60)
                .HasComment("登入密碼")
                .HasColumnName("acpd_LoginPW");
            entity.Property(e => e.AcpdMemo)
                .HasMaxLength(120)
                .HasComment("備註")
                .HasColumnName("acpd_memo");
            entity.Property(e => e.AcpdNowdatetime)
                .HasComment("新增日期")
                .HasColumnType("datetime")
                .HasColumnName("acpd_nowdatetime");
            entity.Property(e => e.AcpdSname)
                .HasMaxLength(40)
                .HasComment(" 簡稱")
                .HasColumnName("acpd_sname");
            entity.Property(e => e.AcpdStatus)
                .HasComment("狀況 0=正常 , 99=不正常")
                .HasColumnName("acpd_status");
            entity.Property(e => e.AcpdStop)
                .HasComment(" 是否停用/不可登入")
                .HasColumnName("acpd_stop");
            entity.Property(e => e.AcpdStopMemo)
                .HasMaxLength(600)
                .HasComment("停用原因")
                .HasColumnName("acpd_stopMemo");
            entity.Property(e => e.AcpdUpddatetitme)
                .HasComment("修改日期")
                .HasColumnType("datetime")
                .HasColumnName("acpd_upddatetitme");
            entity.Property(e => e.AcpdUpdid)
                .HasMaxLength(20)
                .HasComment("修改人員代碼")
                .HasColumnName("acpd_updid");
            entity.Property(e => e.AppdNowid)
                .HasMaxLength(20)
                .HasComment("新增人員代碼")
                .HasColumnName("appd_nowid");
        });

        modelBuilder.Entity<MyofficeExcuteionLog>(entity =>
        {
            entity.HasKey(e => e.DeLogAuthId);

            entity.ToTable("Myoffice_ExcuteionLog");

            entity.Property(e => e.DeLogAuthId)
                .ValueGeneratedNever()
                .HasComment("自訂索引碼")
                .HasColumnName("DeLog_AuthID");
            entity.Property(e => e.DeLogExecuteionInfo)
                .HasComment("執行的內容或是說明")
                .HasColumnName("DeLog_ExecuteionInfo");
            entity.Property(e => e.DeLogExecutionProgram)
                .HasMaxLength(120)
                .HasComment("執行的項目")
                .HasColumnName("DeLog_ExecutionProgram");
            entity.Property(e => e.DeLogGroupId)
                .HasComment("執行的群組代碼")
                .HasColumnName("DeLog_GroupID");
            entity.Property(e => e.DeLogIsCustomDebug)
                .HasComment("是否認定為 Bug")
                .HasColumnName("DeLog_isCustomDebug");
            entity.Property(e => e.DeLogStoredPrograms)
                .HasMaxLength(120)
                .HasComment("預存程序名稱")
                .HasColumnName("DeLog_StoredPrograms");
            entity.Property(e => e.DeLogVerifyNeeded)
                .HasComment("此錯誤是否要進行檢查")
                .HasColumnName("DeLog_VerifyNeeded");
            entity.Property(e => e.ExelogNowdatetime)
                .HasComment("新增日期")
                .HasColumnType("datetime")
                .HasColumnName("exelog_nowdatetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
