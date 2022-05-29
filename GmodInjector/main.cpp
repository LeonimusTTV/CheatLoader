#include <iostream>
#include <Windows.h>
#include <TlHelp32.h>
#include <tchar.h>

DWORD getProcess() {
	HANDLE hPID = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
	PROCESSENTRY32 procEntry;
	procEntry.dwSize = sizeof(procEntry);

	do {
		if (!_tcsicmp(procEntry.szExeFile, _T("gmod.exe"))) {
			DWORD dwPID = procEntry.th32ProcessID;
			CloseHandle(hPID);

			return dwPID;
		}
	} while (Process32Next(hPID, &procEntry));
}

int main() {
	// declare variables
	char dll[MAX_PATH];

	DWORD dwProcess;
	char myDLL[MAX_PATH];

	// get process
	dwProcess = getProcess();

	// open handle and allocate memory
	HANDLE hProcess = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_VM_OPERATION, FALSE, dwProcess);
	LPVOID allocatedMem = VirtualAllocEx(hProcess, NULL, sizeof(myDLL), MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);

	// actually "inject" DLL into process memory
	WriteProcessMemory(hProcess, allocatedMem, myDLL, sizeof(myDLL), NULL);

	// launch DLL
	CreateRemoteThread(hProcess, 0, 0, (LPTHREAD_START_ROUTINE)LoadLibrary, allocatedMem, 0, 0);

	// close handle
	CloseHandle(hProcess);

	// done
	return 0;
}