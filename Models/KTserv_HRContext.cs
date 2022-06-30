using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRnew.Models
{
    public partial class KTserv_HRContext : DbContext
    {
        public KTserv_HRContext()
        {
        }

        public KTserv_HRContext(DbContextOptions<KTserv_HRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceEmployee> AttendanceEmployees { get; set; } = null!;
        public virtual DbSet<AttendanceStudent> AttendanceStudents { get; set; } = null!;
        public virtual DbSet<EmployeeCertificateVerification> EmployeeCertificateVerifications { get; set; } = null!;
        public virtual DbSet<EmployeeCourseBach> EmployeeCourseBaches { get; set; } = null!;
        public virtual DbSet<EmployeeDailyTimesheet> EmployeeDailyTimesheets { get; set; } = null!;
        public virtual DbSet<EmployeeFamilyBackground> EmployeeFamilyBackgrounds { get; set; } = null!;
        public virtual DbSet<EmployeeHistory> EmployeeHistories { get; set; } = null!;
        public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; } = null!;
        public virtual DbSet<EmployeeRegistration> EmployeeRegistrations { get; set; } = null!;
        public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; } = null!;
        public virtual DbSet<EmployeeSalaryPayment> EmployeeSalaryPayments { get; set; } = null!;
        public virtual DbSet<HrBatch> HrBatches { get; set; } = null!;
        public virtual DbSet<HrCourse> HrCourses { get; set; } = null!;
        public virtual DbSet<HrDepartment> HrDepartments { get; set; } = null!;
        public virtual DbSet<HrDesignation> HrDesignations { get; set; } = null!;
        public virtual DbSet<HrFeedback> HrFeedbacks { get; set; } = null!;
        public virtual DbSet<HrInterview> HrInterviews { get; set; } = null!;
        public virtual DbSet<HrInterviewCandidate> HrInterviewCandidates { get; set; } = null!;
        public virtual DbSet<HrMeeting> HrMeetings { get; set; } = null!;
        public virtual DbSet<HrNotificationSetting> HrNotificationSettings { get; set; } = null!;
        public virtual DbSet<HrOfferLetter> HrOfferLetters { get; set; } = null!;
        public virtual DbSet<HrPageAccess> HrPageAccesses { get; set; } = null!;
        public virtual DbSet<HrResignation> HrResignations { get; set; } = null!;
        public virtual DbSet<HrSkill> HrSkills { get; set; } = null!;
        public virtual DbSet<HrSubscrib> HrSubscribs { get; set; } = null!;
        public virtual DbSet<HrTaskReg> HrTaskRegs { get; set; } = null!;
        public virtual DbSet<StudentFee> StudentFees { get; set; } = null!;
        public virtual DbSet<StudentLeave> StudentLeaves { get; set; } = null!;
        public virtual DbSet<StudentProject> StudentProjects { get; set; } = null!;
        public virtual DbSet<StudentRegistration> StudentRegistrations { get; set; } = null!;
        public virtual DbSet<VisiterAppointment> VisiterAppointments { get; set; } = null!;
        public virtual DbSet<VisiterRegistration> VisiterRegistrations { get; set; } = null!;
        public virtual DbSet<VisiterRequirement> VisiterRequirements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A4NBJKG\\SIBINSQL;Initial Catalog=KTserv_HR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpAttendanceId)
                    .HasName("PK_Attendance_EmployeeDaily");

                entity.ToTable("Attendance_Employee");

                entity.Property(e => e.EmpAttendanceId).HasColumnName("EmpAttendanceID");

                entity.Property(e => e.DailyMailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraTimePerDay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Inphoto)
                    .HasColumnType("image")
                    .HasColumnName("INphoto");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("INtime");

                entity.Property(e => e.Outphoto)
                    .HasColumnType("image")
                    .HasColumnName("OUTphoto");

                entity.Property(e => e.Outtime)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTtime");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceStudent>(entity =>
            {
                entity.HasKey(e => e.StudAttendanceId)
                    .HasName("PK_Attendance_StudentDaily");

                entity.ToTable("Attendance_Student");

                entity.Property(e => e.StudAttendanceId).HasColumnName("StudAttendanceID");

                entity.Property(e => e.DailyMailStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraTimePerDay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Inphoto)
                    .HasColumnType("image")
                    .HasColumnName("INphoto");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("INtime");

                entity.Property(e => e.Outphoto)
                    .HasColumnType("image")
                    .HasColumnName("OUTphoto");

                entity.Property(e => e.Outtime)
                    .HasColumnType("datetime")
                    .HasColumnName("OUTtime");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.StudNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeCertificateVerification>(entity =>
            {
                entity.HasKey(e => e.CertificateVerificationId)
                    .HasName("PK_hr_EmpCertificateVerification");

                entity.ToTable("Employee_CertificateVerification");

                entity.Property(e => e.CertificateVerificationId).HasColumnName("CertificateVerificationID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeCourseBach>(entity =>
            {
                entity.HasKey(e => e.EmpCourseBachId)
                    .HasName("PK_hr_EmpCourseBach");

                entity.ToTable("Employee_CourseBach");

                entity.Property(e => e.EmpCourseBachId).HasColumnName("EmpCourseBachID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EmpCourseBachRegDate).HasColumnType("date");

                entity.Property(e => e.EmpCourseBachStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<EmployeeDailyTimesheet>(entity =>
            {
                entity.HasKey(e => e.TimesheetId)
                    .HasName("PK_hr_TaskTracker");

                entity.ToTable("Employee_DailyTimesheet");

                entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TimesheetDetails).IsUnicode(false);

                entity.Property(e => e.TimesheetEmpStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimesheetHrStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeFamilyBackground>(entity =>
            {
                entity.HasKey(e => e.FamilyBackgroundId)
                    .HasName("PK_hr_FamilyBackground");

                entity.ToTable("Employee_FamilyBackground");

                entity.Property(e => e.FamilyBackgroundId).HasColumnName("FamilyBackgroundID");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrgentContactNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrgentContactNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.HasKey(e => e.EmployeeHisId)
                    .HasName("PK_hr_EmployeeHis");

                entity.ToTable("Employee_History");

                entity.Property(e => e.EmployeeHisId).HasColumnName("EmployeeHisID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Experience).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hrcomments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRComments");

                entity.Property(e => e.HrcontactNumber).HasColumnName("HRContactNumber");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeLeave>(entity =>
            {
                entity.HasKey(e => e.EmpLeaveId)
                    .HasName("PK_hr_Leave");

                entity.ToTable("Employee_Leave");

                entity.Property(e => e.EmpLeaveId).HasColumnName("Emp_LeaveID");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.LeaveBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LeaveFrom).HasColumnType("datetime");

                entity.Property(e => e.LeaveReason).IsUnicode(false);

                entity.Property(e => e.LeaveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveTo).HasColumnType("datetime");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Paid,Normal");
            });

            modelBuilder.Entity<EmployeeRegistration>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_hr_Employee");

                entity.ToTable("Employee_Registration");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Where the employee is located in corporate hierarchy.");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId)
                    .HasColumnName("DesignationID")
                    .HasComment("Work title such as Buyer or Sales Representative.");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB")
                    .HasComment("Date of birth.");

                entity.Property(e => e.EmpGender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Network login.");

                entity.Property(e => e.EmpIdno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpIDno");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Unique national identification number such as a social security number.");

                entity.Property(e => e.EmpPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasComment("Employee hired on this date.");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("M = Married, S = Single");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PicturePath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");
            });

            modelBuilder.Entity<EmployeeSalary>(entity =>
            {
                entity.HasKey(e => e.EmpSalId)
                    .HasName("PK_hr_EmployeeSal");

                entity.ToTable("Employee_Salary");

                entity.Property(e => e.EmpSalId).HasColumnName("EmpSalID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.SalaryAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeSalaryPayment>(entity =>
            {
                entity.HasKey(e => e.EmpSalId);

                entity.ToTable("Employee_Salary_Payment");

                entity.Property(e => e.EmpSalId).HasColumnName("EmpSalID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.SalAdvancePaidAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalAdvancePaidDate).HasColumnType("datetime");

                entity.Property(e => e.SalAdvancePaidStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalPaidDate).HasColumnType("datetime");

                entity.Property(e => e.SalPaidStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryPaidAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryPaidYearMonth)
                    .HasColumnType("date")
                    .HasColumnName("SalaryPaid_YearMonth");
            });

            modelBuilder.Entity<HrBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK_hr_Bach");

                entity.ToTable("hr_Batch");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TuterEmpId).HasColumnName("TuterEmpID");
            });

            modelBuilder.Entity<HrCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("hr_Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourseDuration)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourseFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseRegDate).HasColumnType("date");

                entity.Property(e => e.CourseStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("hr_Department");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("Primary key for Department records.");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Hod).HasColumnName("HOD");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Name of the department.");
            });

            modelBuilder.Entity<HrDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId);

                entity.ToTable("hr_Designation");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DutiesAssigned)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.ToTable("hr_Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.FeedbackAbout)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrInterview>(entity =>
            {
                entity.HasKey(e => e.InterviewId);

                entity.ToTable("hr_Interview");

                entity.Property(e => e.InterviewId).HasColumnName("InterviewID");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewStatus).HasMaxLength(50);

                entity.Property(e => e.Interviewee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntervieweeAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IntervieweeDob)
                    .HasColumnType("date")
                    .HasColumnName("IntervieweeDOB");

                entity.Property(e => e.IntervieweeSkills)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Interviewer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionFor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PracticalTime).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TheoryTime).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<HrInterviewCandidate>(entity =>
            {
                entity.HasKey(e => e.InterviewCandidateId);

                entity.ToTable("hr_InterviewCandidate");

                entity.Property(e => e.InterviewCandidateId)
                    .ValueGeneratedNever()
                    .HasColumnName("interviewCandidateID");

                entity.Property(e => e.DifferentlyAble)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ifsc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IFSC");

                entity.Property(e => e.InterviewDate).HasColumnType("date");

                entity.Property(e => e.LastDrawnAnnualSalaryCtc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("LastDrawnAnnualSalary_CTC");

                entity.Property(e => e.MonthlySalaryonJoining).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RelevantYearsExperience)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RelevantYears_Experience");

                entity.Property(e => e.Resume).HasColumnType("image");

                entity.Property(e => e.ResumeHandoverBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResumeHandoverDate).HasColumnType("date");

                entity.Property(e => e.ResumePath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalYearsExperience)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TotalYears_Experience");
            });

            modelBuilder.Entity<HrMeeting>(entity =>
            {
                entity.HasKey(e => e.MeetingId);

                entity.ToTable("hr_Meeting");

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.MeetingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingHeading)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrNotificationSetting>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK_hr_Notification_Settings");

                entity.ToTable("hr_NotificationSettings");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.NotificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.NotificationDescription).IsUnicode(false);

                entity.Property(e => e.NotificationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrOfferLetter>(entity =>
            {
                entity.HasKey(e => e.OfferLetterId);

                entity.ToTable("hr_OfferLetter");

                entity.Property(e => e.OfferLetterId).HasColumnName("OfferLetterID");

                entity.Property(e => e.ExpectedJoiningDate).HasColumnType("date");

                entity.Property(e => e.OfferedSalary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PostApplied)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<HrPageAccess>(entity =>
            {
                entity.HasKey(e => e.PageAccessId);

                entity.ToTable("hr_PageAccess");

                entity.Property(e => e.PageAccessId).HasColumnName("PageAccessID");

                entity.Property(e => e.PageHandledBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrResignation>(entity =>
            {
                entity.HasKey(e => e.ResignationId);

                entity.ToTable("hr_Resignation");

                entity.Property(e => e.ResignationId).HasColumnName("ResignationID");

                entity.Property(e => e.ActualLastWorkingDate).HasColumnType("date");

                entity.Property(e => e.AppliedDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedLastWorkingDate).HasColumnType("date");

                entity.Property(e => e.ResignationDate).HasColumnType("date");

                entity.Property(e => e.ResignationStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResignationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortfallAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShortfallDate).HasColumnType("date");
            });

            modelBuilder.Entity<HrSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("hr_Skill");

                entity.Property(e => e.SkillId).HasColumnName("Skill_ID");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrSubscrib>(entity =>
            {
                entity.HasKey(e => e.SubscribeId)
                    .HasName("PK_hr_Subscribb");

                entity.ToTable("hr_Subscrib");

                entity.Property(e => e.SubscribeId).HasColumnName("SubscribeID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mailid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscribeDateTime).HasColumnType("date");

                entity.Property(e => e.SubscribeDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubscribeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscribeSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrTaskReg>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("hr_TaskReg");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskRegDate).HasColumnType("datetime");

                entity.Property(e => e.TaskStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaskTargetDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StudentFee>(entity =>
            {
                entity.HasKey(e => e.StudFeeId)
                    .HasName("PK_hr_StudFee");

                entity.ToTable("Student_Fee");

                entity.Property(e => e.StudFeeId).HasColumnName("StudFeeID");

                entity.Property(e => e.FeeAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FeeAmountPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FeePaidDate).HasColumnType("datetime");

                entity.Property(e => e.FeeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfInstallment).HasColumnName("Number_of_Installment");

                entity.Property(e => e.NumberOfInstallmentPaid).HasColumnName("Number_of_InstallmentPaid");

                entity.Property(e => e.StudId).HasColumnName("StudID");
            });

            modelBuilder.Entity<StudentLeave>(entity =>
            {
                entity.HasKey(e => e.StudLeaveId)
                    .HasName("PK_hr_Leave_Student");

                entity.ToTable("Student_Leave");

                entity.Property(e => e.StudLeaveId).HasColumnName("Stud_LeaveID");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LeaveFrom).HasColumnType("datetime");

                entity.Property(e => e.LeaveReason).IsUnicode(false);

                entity.Property(e => e.LeaveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveTo).HasColumnType("datetime");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Paid,Normal");

                entity.Property(e => e.StudId).HasColumnName("StudID");
            });

            modelBuilder.Entity<StudentProject>(entity =>
            {
                entity.HasKey(e => e.StudProjectId)
                    .HasName("PK_hr_StudProject");

                entity.ToTable("Student_Project");

                entity.Property(e => e.StudProjectId).HasColumnName("StudProjectID");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.StudProjectCompletionDate).HasColumnType("date");

                entity.Property(e => e.StudProjectDescription).IsUnicode(false);

                entity.Property(e => e.StudProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudProjectPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudProjectStartDate).HasColumnType("date");

                entity.Property(e => e.StudProjectStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudProjectTechnologies)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentRegistration>(entity =>
            {
                entity.HasKey(e => e.StudId)
                    .HasName("PK_StudentReg");

                entity.ToTable("Student_Registration");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.BachId).HasColumnName("BachID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.StudAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StudDob)
                    .HasColumnType("date")
                    .HasColumnName("StudDOB");

                entity.Property(e => e.StudGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudRegDate).HasColumnType("date");

                entity.Property(e => e.StudStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudUpdtDate).HasColumnType("date");
            });

            modelBuilder.Entity<VisiterAppointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.ToTable("Visiter_Appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");

                entity.Property(e => e.AppointmentDateTime).HasColumnType("datetime");

                entity.Property(e => e.AppointmentDetails).IsUnicode(false);

                entity.Property(e => e.AppointmentRegDateTime).HasColumnType("datetime");

                entity.Property(e => e.AppointmentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentUpdtDateTime).HasColumnType("datetime");

                entity.Property(e => e.VisiterId).HasColumnName("VisiterID");
            });

            modelBuilder.Entity<VisiterRegistration>(entity =>
            {
                entity.HasKey(e => e.UsrId);

                entity.ToTable("Visiter_Registration");

                entity.Property(e => e.UsrId).HasColumnName("UsrID");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.MailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MailID");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UptDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisiterAddress).IsUnicode(false);

                entity.Property(e => e.VisiterFullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisiterPurpose).IsUnicode(false);
            });

            modelBuilder.Entity<VisiterRequirement>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("Visiter_Requirement");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.AssignedToVisiterId).HasColumnName("AssignedTo_VisiterID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaskStatus).HasComment("ToDo to Normal to Moderate to High to Overdue to Deployed");

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UptDate).HasColumnType("datetime");

                entity.Property(e => e.VisiterTask)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
