A repository for testing display model code in NVDA.
It contains several projects to build applications based on historically popular GUI APIs.
- MFC app.
- WinForms with Custom GDI code.
- A win32 desktop app, with GDI code.

# Build requirements
In addition to the build requiremets for NVDA, also install:
- component: "C++ MFC for latest v142 build tools (x86 & x64)"
- ".Net desktop development"

Or import from the 'dependencies.vsconfig'

# Building
Open mfcTest.sln with Visual Studio, and Build All

# GDItest
A C# winforms application with a custom paint method.

# RawGDI
A Win 32 C++ desktop application that uses GDI directly.
See doPaint in RawGDI.cpp

# mfcTest

Note to those unfamilar with MFC:
- In this repo, dialog layout is stored in *.rc files.
- Although text based editing is possible, they are re-written (and re-ordered) by designer tool.
- Git treats these as binary files.
- The can be diffed by external (to git) diff tools, but due to re-ordering this can be difficult.
- To diff these files, it may be easiest to copy and diff sections of the file individually.

