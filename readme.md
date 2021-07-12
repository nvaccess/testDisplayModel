A repository for testing display model code in NVDA.
A basic MFC app for testing the display model, at least the GDI calls.

Note to those unfamilar with MFC:
- In this repo, dialog layout is stored in *.rc files.
- Although text based editing is possible, they are re-written (and re-ordered) by designer tool.
- Git treats these as binary files.
- The can be diffed by external (to git) diff tools, but due to re-ordering this can be difficult.
- To diff these files, it may be easiest to copy and diff sections of the file individually.


# Build requirements
In addition to the build requiremets for NVDA, also install the component:
"C++ MFC for latest v142 build tools (x86 & x64)"

A full listing:
* Microsoft Visual Studio 2019 Community, Version 16.3 or later:
	* Download from https://visualstudio.microsoft.com/vs/
	* When installing Visual Studio, you need to enable the following:
		* On the Workloads tab
			* in the Windows group:
				* Desktop development with C++
			* Then in the Installation details section, under Desktop for C++, Optional grouping, ensure the following are selected:
				* MSVC v142 - VS 2019 C++ x64/x86 build tools
				* Windows 10 SDK (10.0.19041.0)
				* C++ ATL for v142 build tools (x86 & x64)
				* C++ Clang tools for Windows
		* On the Individual components tab, ensure the following items are selected:
			* C++ MFC for latest v142 build tools (x86 & x64)


# Building
Open mfcTest.sln with Visual Studio, and Build All
