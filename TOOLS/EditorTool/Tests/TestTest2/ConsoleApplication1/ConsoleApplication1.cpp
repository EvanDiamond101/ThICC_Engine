// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <fstream>
#include <vector>
#include <iostream>


int main()
{
	//Open file stream
	std::ifstream fin("bytes.bin", std::ios::binary);

	//Get the number of collision groups
	fin.seekg(0);
	int number_of_coll_types1 = 0;
	int number_of_coll_types2 = 0;
	int number_of_coll_types3 = 0;
	fin.read(reinterpret_cast<char*>(&number_of_coll_types1), sizeof(int));
	fin.read(reinterpret_cast<char*>(&number_of_coll_types2), sizeof(int));
	fin.read(reinterpret_cast<char*>(&number_of_coll_types3), sizeof(int));

	std::cout << number_of_coll_types1 << std::endl;
	std::cout << number_of_coll_types2 << std::endl;
	std::cout << number_of_coll_types3 << std::endl;

    return 0;
}

