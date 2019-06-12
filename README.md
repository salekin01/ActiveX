<h2>ActiveX</h2>
  <p>ActiveX is a Microsoft-created technology that enables different software applications to share information and functionality. ActiveX only works with Microsoft applications like Word, Excel, Internet Explorer and PowerPoint, and will only work on a computer running the Windows operating system.</p>

<h2>Prerequisites</h2>
	<ul>
		<li><h5>Internet Explorer(IE)</h5></li>
			<p>ActiveX only works at Internet Explorer(IE).</p>
		<li><h5>Enabling ActiveX in IE</h5></li>
			<ol type="a">
				<li>IE has to be opened as "Run as Administrator" mode.</li>
				<li>Go IE settings-> internet options-> security tab-> custom level -> Initialize and Script ActiveX controls not mark as safe for scripting (mark it enable)</li>
			</ol>
	</ul>

<h2>Open a .txt file from browser using ActiveX</h2>
	<ul>
		<li>In order to open a txt file, a txt file(named as Notepad) has to be created in C drive</li>
		<li>Open ActiveX page</li>
		<li>Click the button "ActiveX File Calling"</li>
	</ul>

<h2>Call a DLL file from browser using ActiveX</h2>
	<ol>
		<li>"ActiveXClass.cs" class has to be putted in "C:\Windows\Microsoft.NET\Framework\v4.0.30319" directory.</li>
		<li>Then we have to make a dll of this class in that directory and then register that created dll. To do this:</li>
			<ol>
				<li>run command prompt(Admin)</li>
				<li>cd C:\Windows\Microsoft.NET\Framework\v4.0.30319             [go to the directory]</li>
				<li>csc /target:library /out:ActiveXClass.DLL ActiveXClass.cs    [create dll of that class]</li>
				<li>regasm ActiveXClass.dll /tlb /codebase                       [register dll] </br></li>
						csc /out:ActiveXClass.DLL /reference:MathLibrary.DLL ActiveXClass.cs    [only necessary if the dll has reference of other dll and then we will use this line instead of line 4 ]
			</ol>
	</ol>

