using System;
using WixSharp;

class Script
{
    static public void Main()
    {
        const string ProgramFolderName = "Certificate Registry 3";

        Compiler.WixLocation = @"..\packages\WixSharp.wix.bin.3.11.2\tools\bin";

        var project = new Project("CertificateRegistry3",
                        // папка установки
                        new Dir($@"%ProgramFiles%\{ProgramFolderName}",
                            // файлы программы
                            new File(@"..\CertificateRegistry3\bin\Release\CertificateRegistry3.exe"),
                            new File(@"..\CertificateRegistry3\bin\Release\CertificateRegistry3.exe.config"),
                            new File(@"..\CertificateRegistry3\bin\Release\EntityFramework.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\EntityFramework.SqlServer.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\Microsoft.Bcl.AsyncInterfaces.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\Npgsql.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Buffers.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Data.SQLite.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Data.SQLite.EF6.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Data.SQLite.Linq.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Memory.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Numerics.Vectors.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Text.Encodings.Web.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.Text.Json.dll"),
                            new File(@"..\CertificateRegistry3\bin\Release\System.ValueTuple.dll"),
                            // вложенные папки
                            new Dir(@"x64", new File(@"..\CertificateRegistry3\bin\Release\x64\SQLite.Interop.dll")),
                            new Dir(@"x86", new File(@"..\CertificateRegistry3\bin\Release\x86\SQLite.Interop.dll"))
                        ),
                        // папка с ярлыками в меню
                        new Dir($@"%ProgramMenu%\{ProgramFolderName}",
                            new ExeFileShortcut(ProgramFolderName, "[INSTALLDIR]CertificateRegistry3.exe", arguments: ""),
                            new ExeFileShortcut("Uninstall program", "[System64Folder]msiexec.exe", arguments: "/x [ProductCode]")),
                        new Dir(@"%Desktop%",
                            new ExeFileShortcut(ProgramFolderName, "[INSTALLDIR]CertificateRegistry3.exe", arguments: ""))
                    );

        project.GUID = new Guid("6978ac45-699b-4e9c-a333-0b4db2e1ef47");
        project.UI = WUI.WixUI_InstallDir;
        project.ControlPanelInfo.InstallLocation = "[INSTALLDIR]";
        project.LicenceFile = "license.rtf";

        Compiler.BuildMsi(project);
    }
}