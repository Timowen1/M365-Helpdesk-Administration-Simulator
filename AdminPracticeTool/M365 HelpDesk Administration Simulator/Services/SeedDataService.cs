using System;
using System.Collections.Generic;
using M365_HelpDesk_Administration_Simulator.Models;
using M365_HelpDesk_Administration_Simulator.Storage;

namespace M365_HelpDesk_Administration_Simulator.Services
{
    public static class SeedDataService
    {
        public static FakeDataStore CreateSeedData()
        {
            var store = new FakeDataStore();



            var blankGroup  = new SecurityGroup
            {
                Name = "   ",
                Description = "This is a blank group for testing purposes."
            };
            var salesGroup = new SecurityGroup
            {
                Name = "Sales-SharedDrive-Access",
                Description = "Allows access to the Sales shared drive."
            };

            var hrGroup = new SecurityGroup
            {
                Name = "HR-SharedDrive-Access",
                Description = "Allows access to HR resources."
            };

            var helpdeskGroup = new SecurityGroup
            {
                Name = "Helpdesk-Technicians",
                Description = "Basic helpdesk technician access."
            };

            store.Groups.Add(blankGroup);
            store.Groups.Add(salesGroup);
            store.Groups.Add(hrGroup);
            store.Groups.Add(helpdeskGroup);

            var operationsGroup = new SecurityGroup
            {
                Name = "Operations-SharedDrive-Access",
                Description = "Allows access to Operations shared drive."
            };

            var financeGroup = new SecurityGroup
            {
                Name = "Finance-SharedDrive-Access",
                Description = "Allows access to Finance shared drive."
            };

            var vpnGroup = new SecurityGroup
            {
                Name = "VPN-Users",
                Description = "Allows users to connect through VPN."
            };

            var mfaExemptGroup = new SecurityGroup
            {
                Name = "MFA-Temporary-Bypass",
                Description = "Temporary MFA bypass group. Use with caution."
            };

            store.Groups.Add(operationsGroup);
            store.Groups.Add(financeGroup);
            store.Groups.Add(vpnGroup);
            store.Groups.Add(mfaExemptGroup);

            var sarah = new UserAccount
            {
                FirstName = "Sarah",
                LastName = "Miller",
                Email = "sarah.miller@northstar.local",
                Department = "Sales",
                Role = UserRole.User,


                HasMailLicense = true,
                MailboxFull = true,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""

            };

            var mike = new UserAccount
            {
                FirstName = "Mike",
                LastName = "Johnson",
                Email = "mike.johnson@northstar.local",
                Department = "Operations",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = true,
                ForwardingAddress = "old.personal.email@example.com"

            };

            var nina = new UserAccount
            {
                FirstName = "Nina",
                LastName = "Patel",
                Email = "nina.patel@northstar.local",
                Department = "IT",
                Role = UserRole.Helpdesk,

                HasMailLicense = false,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""
            };

            var jeff = new UserAccount
            {
                FirstName = "Jeff",
                LastName = "Anderson",
                Email = "jeff.anderson@northstar.local",
                Department = "Finance",
                Role = UserRole.User,

                HasMailLicense = false,
                MailboxFull = true,
                MailboxBlocked = true,
                ForwardingEnabled = false,
                ForwardingAddress = "jeffanderson@gmail.com"

            };

            var brad = new UserAccount
            {
                FirstName = "Brad",
                LastName = "Hemlock",
                Email = "brad.hemlock@northstar.local",
                Department = "Finance",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""

            };

            var joe = new UserAccount
            {
                FirstName = "Joe",
                LastName = "Shoemick",
                Email = "joe.shoemick@northstar.local",
                Department = "IT",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""

            };

            var emilyCarter = new UserAccount
            {
                FirstName = "Emily",
                LastName = "Carter",
                Email = "emily.carter@northstar.local",
                Department = "Human Resources",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""
            };

            var danielBrooks = new UserAccount
            {
                FirstName = "Daniel",
                LastName = "Brooks",
                Email = "daniel.brooks@northstar.local",
                Department = "IT",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""
            };

            var oliviaBennett = new UserAccount
            {
                FirstName = "Olivia",
                LastName = "Bennett",
                Email = "olivia.bennett@northstar.local",
                Department = "Finance",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = false,
                ForwardingAddress = ""
            };

            var ethanWalker = new UserAccount
            {
                FirstName = "Ethan",
                LastName = "Walker",
                Email = "ethan.walker@northstar.local",
                Department = "Operations",
                Role = UserRole.User,

                HasMailLicense = true,
                MailboxFull = false,
                MailboxBlocked = false,
                ForwardingEnabled = true,
                ForwardingAddress = "johnwick20@gmail.com"
            };

            var sophiaReed = new UserAccount
            {
                FirstName = "Sophia",
                LastName = "Reed",
                Email = "sophia.reed@northstar.local",
                Department = "Marketing",
                Role = UserRole.User
            };

            var liamFoster = new UserAccount
            {
                FirstName = "Liam",
                LastName = "Foster",
                Email = "liam.foster@northstar.local",
                Department = "Sales",
                Role = UserRole.User
            };

            var avaCollins = new UserAccount
            {
                FirstName = "Ava",
                LastName = "Collins",
                Email = "ava.collins@northstar.local",
                Department = "Customer Support",
                Role = UserRole.User
            };

            var noahMitchell = new UserAccount
            {
                FirstName = "Noah",
                LastName = "Mitchell",
                Email = "noah.mitchell@northstar.local",
                Department = "Engineering",
                Role = UserRole.User
            };

            var graceTurner = new UserAccount
            {
                FirstName = "Grace",
                LastName = "Turner",
                Email = "grace.turner@northstar.local",
                Department = "Legal",
                Role = UserRole.User
            };

            var masonParker = new UserAccount
            {
                FirstName = "Mason",
                LastName = "Parker",
                Email = "mason.parker@northstar.local",
                Department = "Facilities",
                Role = UserRole.User
            };

            var chloeRichardson = new UserAccount
            {
                FirstName = "Chloe",
                LastName = "Richardson",
                Email = "chloe.richardson@northstar.local",
                Department = "Human Resources",
                Role = UserRole.User
            };

            var lucasMorgan = new UserAccount
            {
                FirstName = "Lucas",
                LastName = "Morgan",
                Email = "lucas.morgan@northstar.local",
                Department = "IT",
                Role = UserRole.User
            };

            var miaCooper = new UserAccount
            {
                FirstName = "Mia",
                LastName = "Cooper",
                Email = "mia.cooper@northstar.local",
                Department = "Finance",
                Role = UserRole.User
            };

            var jacksonBailey = new UserAccount
            {
                FirstName = "Jackson",
                LastName = "Bailey",
                Email = "jackson.bailey@northstar.local",
                Department = "Operations",
                Role = UserRole.User
            };

            var lilyPeterson = new UserAccount
            {
                FirstName = "Lily",
                LastName = "Peterson",
                Email = "lily.peterson@northstar.local",
                Department = "Marketing",
                Role = UserRole.User
            };

            var henryWard = new UserAccount
            {
                FirstName = "Henry",
                LastName = "Ward",
                Email = "henry.ward@northstar.local",
                Department = "Sales",
                Role = UserRole.User
            };

            var zoeyRamirez = new UserAccount
            {
                FirstName = "Zoey",
                LastName = "Ramirez",
                Email = "zoey.ramirez@northstar.local",
                Department = "Customer Support",
                Role = UserRole.User
            };

            var loganPrice = new UserAccount
            {
                FirstName = "Logan",
                LastName = "Price",
                Email = "logan.price@northstar.local",
                Department = "Engineering",
                Role = UserRole.User
            };

            var nataliePowell = new UserAccount
            {
                FirstName = "Natalie",
                LastName = "Powell",
                Email = "natalie.powell@northstar.local",
                Department = "Legal",
                Role = UserRole.User
            };

            var calebHughes = new UserAccount
            {
                FirstName = "Caleb",
                LastName = "Hughes",
                Email = "caleb.hughes@northstar.local",
                Department = "Facilities",
                Role = UserRole.User
            };

            var hannahLong = new UserAccount
            {
                FirstName = "Hannah",
                LastName = "Long",
                Email = "hannah.long@northstar.local",
                Department = "Human Resources",
                Role = UserRole.User
            };

            var owenButler = new UserAccount
            {
                FirstName = "Owen",
                LastName = "Butler",
                Email = "owen.butler@northstar.local",
                Department = "IT",
                Role = UserRole.User
            };

            var victoriaBarnes = new UserAccount
            {
                FirstName = "Victoria",
                LastName = "Barnes",
                Email = "victoria.barnes@northstar.local",
                Department = "Finance",
                Role = UserRole.User
            };

            var gabrielRoss = new UserAccount
            {
                FirstName = "Gabriel",
                LastName = "Ross",
                Email = "gabriel.ross@northstar.local",
                Department = "Operations",
                Role = UserRole.User
            };

            var stellaHenderson = new UserAccount
            {
                FirstName = "Stella",
                LastName = "Henderson",
                Email = "stella.henderson@northstar.local",
                Department = "Marketing",
                Role = UserRole.User
            };

            var isaacColeman = new UserAccount
            {
                FirstName = "Isaac",
                LastName = "Coleman",
                Email = "isaac.coleman@northstar.local",
                Department = "Sales",
                Role = UserRole.User
            };

            var leahJenkins = new UserAccount
            {
                FirstName = "Leah",
                LastName = "Jenkins",
                Email = "leah.jenkins@northstar.local",
                Department = "Customer Support",
                Role = UserRole.User
            };

            var julianPerry = new UserAccount
            {
                FirstName = "Julian",
                LastName = "Perry",
                Email = "julian.perry@northstar.local",
                Department = "Engineering",
                Role = UserRole.User
            };

            var claireSimmons = new UserAccount
            {
                FirstName = "Claire",
                LastName = "Simmons",
                Email = "claire.simmons@northstar.local",
                Department = "Legal",
                Role = UserRole.User
            };

            var wyattFisher = new UserAccount
            {
                FirstName = "Wyatt",
                LastName = "Fisher",
                Email = "wyatt.fisher@northstar.local",
                Department = "Facilities",
                Role = UserRole.User
            };

            var rubyBryant = new UserAccount
            {
                FirstName = "Ruby",
                LastName = "Bryant",
                Email = "ruby.bryant@northstar.local",
                Department = "Human Resources",
                Role = UserRole.User
            };

            var leoGraham = new UserAccount
            {
                FirstName = "Leo",
                LastName = "Graham",
                Email = "leo.graham@northstar.local",
                Department = "IT",
                Role = UserRole.User
            };

            var mayaAlexander = new UserAccount
            {
                FirstName = "Maya",
                LastName = "Alexander",
                Email = "maya.alexander@northstar.local",
                Department = "Finance",
                Role = UserRole.User
            };

            var nathanWest = new UserAccount
            {
                FirstName = "Nathan",
                LastName = "West",
                Email = "nathan.west@northstar.local",
                Department = "Operations",
                Role = UserRole.User
            };

            var ellaRussell = new UserAccount
            {
                FirstName = "Ella",
                LastName = "Russell",
                Email = "ella.russell@northstar.local",
                Department = "Marketing",
                Role = UserRole.User
            };

            var connorGriffin = new UserAccount
            {
                FirstName = "Connor",
                LastName = "Griffin",
                Email = "connor.griffin@northstar.local",
                Department = "Sales",
                Role = UserRole.User
            };

            var sadieDiaz = new UserAccount
            {
                FirstName = "Sadie",
                LastName = "Diaz",
                Email = "sadie.diaz@northstar.local",
                Department = "Customer Support",
                Role = UserRole.User
            };

            var aaronHayes = new UserAccount
            {
                FirstName = "Aaron",
                LastName = "Hayes",
                Email = "aaron.hayes@northstar.local",
                Department = "Engineering",
                Role = UserRole.User
            };

            var lucyMyers = new UserAccount
            {
                FirstName = "Lucy",
                LastName = "Myers",
                Email = "lucy.myers@northstar.local",
                Department = "Legal",
                Role = UserRole.User
            };

            var adrianFord = new UserAccount
            {
                FirstName = "Adrian",
                LastName = "Ford",
                Email = "adrian.ford@northstar.local",
                Department = "Facilities",
                Role = UserRole.User
            };

            var bellaHamilton = new UserAccount
            {
                FirstName = "Bella",
                LastName = "Hamilton",
                Email = "bella.hamilton@northstar.local",
                Department = "Human Resources",
                Role = UserRole.User
            };

            var eliStone = new UserAccount
            {
                FirstName = "Eli",
                LastName = "Stone",
                Email = "eli.stone@northstar.local",
                Department = "IT",
                Role = UserRole.User
            };

            var penelopeWoods = new UserAccount
            {
                FirstName = "Penelope",
                LastName = "Woods",
                Email = "penelope.woods@northstar.local",
                Department = "Finance",
                Role = UserRole.User
            };

            var dylanWebb = new UserAccount
            {
                FirstName = "Dylan",
                LastName = "Webb",
                Email = "dylan.webb@northstar.local",
                Department = "Operations",
                Role = UserRole.User
            };

            var ariaCole = new UserAccount
            {
                FirstName = "Aria",
                LastName = "Cole",
                Email = "aria.cole@northstar.local",
                Department = "Marketing",
                Role = UserRole.User
            };

            var cameronOwens = new UserAccount
            {
                FirstName = "Cameron",
                LastName = "Owens",
                Email = "cameron.owens@northstar.local",
                Department = "Sales",
                Role = UserRole.User
            };

            var madelineWarren = new UserAccount
            {
                FirstName = "Madeline",
                LastName = "Warren",
                Email = "madeline.warren@northstar.local",
                Department = "Customer Support",
                Role = UserRole.User
            };

            var jeremiahBlack = new UserAccount
            {
                FirstName = "Jeremiah",
                LastName = "Black",
                Email = "jeremiah.black@northstar.local",
                Department = "Engineering",
                Role = UserRole.User
            };

            var autumnDunn = new UserAccount
            {
                FirstName = "Autumn",
                LastName = "Dunn",
                Email = "autumn.dunn@northstar.local",
                Department = "Legal",
                Role = UserRole.User
            };

            var wesleyCarroll = new UserAccount
            {
                FirstName = "Wesley",
                LastName = "Carroll",
                Email = "wesley.carroll@northstar.local",
                Department = "Facilities",
                Role = UserRole.User
            };


            sarah.GroupIds.Add(salesGroup.Id);
            salesGroup.MemberUserIds.Add(sarah.Id);

            nina.GroupIds.Add(helpdeskGroup.Id);
            helpdeskGroup.MemberUserIds.Add(nina.Id);

            store.Users.Add(sarah);
            store.Users.Add(mike);
            store.Users.Add(nina);
            store.Users.Add(jeff);
            store.Users.Add(brad);
            store.Users.Add(joe);
            store.Users.Add(emilyCarter);
            store.Users.Add(danielBrooks);
            store.Users.Add(oliviaBennett);
            store.Users.Add(ethanWalker);
            store.Users.Add(sophiaReed);
            store.Users.Add(liamFoster);
            store.Users.Add(avaCollins);
            store.Users.Add(noahMitchell);
            store.Users.Add(graceTurner);
            store.Users.Add(masonParker);
            store.Users.Add(chloeRichardson);
            store.Users.Add(lucasMorgan);
            store.Users.Add(miaCooper);
            store.Users.Add(jacksonBailey);
            store.Users.Add(lilyPeterson);
            store.Users.Add(henryWard);
            store.Users.Add(zoeyRamirez);
            store.Users.Add(loganPrice);
            store.Users.Add(nataliePowell);
            store.Users.Add(calebHughes);
            store.Users.Add(hannahLong);
            store.Users.Add(owenButler);
            store.Users.Add(victoriaBarnes);
            store.Users.Add(gabrielRoss);
            store.Users.Add(stellaHenderson);
            store.Users.Add(isaacColeman);
            store.Users.Add(leahJenkins);
            store.Users.Add(julianPerry);
            store.Users.Add(claireSimmons);
            store.Users.Add(wyattFisher);
            store.Users.Add(rubyBryant);
            store.Users.Add(leoGraham);
            store.Users.Add(mayaAlexander);
            store.Users.Add(nathanWest);
            store.Users.Add(ellaRussell);
            store.Users.Add(connorGriffin);
            store.Users.Add(sadieDiaz);
            store.Users.Add(aaronHayes);
            store.Users.Add(lucyMyers);
            store.Users.Add(adrianFord);
            store.Users.Add(bellaHamilton);
            store.Users.Add(eliStone);
            store.Users.Add(penelopeWoods);
            store.Users.Add(dylanWebb);
            store.Users.Add(ariaCole);
            store.Users.Add(cameronOwens);
            store.Users.Add(madelineWarren);
            store.Users.Add(jeremiahBlack);
            store.Users.Add(autumnDunn);
            store.Users.Add(wesleyCarroll);


            store.Devices.Add(new Device
            {
                DeviceName = "  ",
                DeviceType = " ",
                OperatingSystem = " ",
                Status = DeviceStatus.NonCompliant,
                AssignedUserId = null
            });

            var sarahLaptop = new Device
            {
                DeviceName = "LAPTOP-SARAH01",
                DeviceType = "Laptop",
                AssignedUserId = sarah.Id,
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,

                WindowsUpdatePending = true,
                BitLockerEnabled = true,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 42,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            };

            var mikeLaptop = new Device
            {
                DeviceName = "LAPTOP-MIKE01",
                DeviceType = "Laptop",
                AssignedUserId = mike.Id,
                OperatingSystem = "Windows 11",

                WindowsUpdatePending = true,
                BitLockerEnabled = true,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 42,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            };

            var ninaLaptop = new Device
            {
                DeviceName = "LAPTOP-MIKE01",
                DeviceType = "Laptop",
                AssignedUserId = mike.Id,
                OperatingSystem = "Windows 11",

                WindowsUpdatePending = true,
                BitLockerEnabled = true,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 42,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            };

            store.Devices.Add(sarahLaptop);
            store.Devices.Add(mikeLaptop);

            sarah.DeviceIds.Add(sarahLaptop.Id);
            mike.DeviceIds.Add(mikeLaptop.Id);

            store.AuditEntries.Add(new AuditEntry
            {
                Actor = "System",
                Action = "Seed Data Created",
                Target = "Simulator",
                Notes = "Initial fake tenant data loaded."
            });


           

            store.Devices.Add(new Device
            {
                DeviceName = "LAPTOP-STOCK01",
                DeviceType = "Laptop",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null,

                 WindowsUpdatePending = true,
                BitLockerEnabled = true,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 42,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            });

            store.Devices.Add(new Device
            {
                DeviceName = "DESKTOP-STOCK02",
                DeviceType = "Desktop",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null,

                WindowsUpdatePending = false,
                BitLockerEnabled = true,
                DefenderEnabled = false,
                DiskSpaceFreePercent = 48,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            });

            store.Devices.Add(new Device
            {
                DeviceName = "DESKTOP-Nina",
                DeviceType = "Desktop",
                OperatingSystem = "Window 8.1",
                Status = DeviceStatus.Active,
                AssignedUserId = nina.Id,
                

                WindowsUpdatePending = false,
                BitLockerEnabled = true,
                DefenderEnabled = false,
                DiskSpaceFreePercent = 48,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            });

            store.Devices.Add(new Device
            {
                DeviceName = "LAPTOP-STOCK07",
                DeviceType = "Laptop",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null,

                WindowsUpdatePending = false,
                BitLockerEnabled = true,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 39,
                DaysSinceLastCheckIn = 14,
                LocalAdminGranted = false
            });

            store.Devices.Add(new Device
            {
                DeviceName = "DESKTOP-STOCK01",
                DeviceType = "Desktop",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null,

                WindowsUpdatePending = false,
                BitLockerEnabled = false,
                DefenderEnabled = true,
                DiskSpaceFreePercent = 52,
                DaysSinceLastCheckIn = 1,
                LocalAdminGranted = false
            });

            store.Devices.Add(new Device
            {
                DeviceName = "DESKTOP-STOCK02",
                DeviceType = "Desktop",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null
            });

            store.Devices.Add(new Device
            {
                DeviceName = "TABLET-STOCK01",
                DeviceType = "Tablet",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null
            });

            store.Devices.Add(new Device
            {
                DeviceName = "TABLET-STOCK02",
                DeviceType = "Tablet",
                OperatingSystem = "Windows 11",
                Status = DeviceStatus.Active,
                AssignedUserId = null
            });

            store.Devices.Add(new Device
            {
                DeviceName = "PHONE-STOCK01",
                DeviceType = "Phone",
                OperatingSystem = "iOS",
                Status = DeviceStatus.Active,
                AssignedUserId = null
            });

            store.Devices.Add(new Device
            {
                DeviceName = "PHONE-STOCK02",
                DeviceType = "Phone",
                OperatingSystem = "Android",
                Status = DeviceStatus.Active,
                AssignedUserId = null
            });

            return store;
        }
    }

}

