#pragma once
#include<iostream>
using namespace System;
namespace ReadFirst {
	public ref class ReadFirst {
	public:virtual int  ReadFirstN() {
		Console::WriteLine("Please type the First Number : ");
		int firstNumber;
		std::cin >> firstNumber;
		return firstNumber;

	}
	};
}
