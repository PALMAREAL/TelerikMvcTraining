namespace TelerikMvcTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProScheduler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeetingAttendees",
                c => new
                    {
                        AttendeeID = c.Int(nullable: false, identity: true),
                        MeetingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttendeeID)
                .ForeignKey("dbo.Meetings", t => t.MeetingID, cascadeDelete: true)
                .Index(t => t.MeetingID);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        MeetingID = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        RoomID = c.Int(),
                        IsAllDay = c.Boolean(nullable: false),
                        RecurrenceRule = c.String(),
                        RecurrenceID = c.Int(),
                        RecurrenceException = c.String(),
                        StartTimezone = c.String(),
                        EndTimezone = c.String(),
                        Meeting1_MeetingID = c.Int(),
                    })
                .PrimaryKey(t => t.MeetingID)
                .ForeignKey("dbo.Meetings", t => t.Meeting1_MeetingID)
                .Index(t => t.Meeting1_MeetingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeetingAttendees", "MeetingID", "dbo.Meetings");
            DropForeignKey("dbo.Meetings", "Meeting1_MeetingID", "dbo.Meetings");
            DropIndex("dbo.Meetings", new[] { "Meeting1_MeetingID" });
            DropIndex("dbo.MeetingAttendees", new[] { "MeetingID" });
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingAttendees");
        }
    }
}
