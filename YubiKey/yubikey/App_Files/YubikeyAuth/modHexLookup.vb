Namespace YubikeyAuth
Public NotInheritable partial Class modHex

    'Majorly overkill....

    public shared ReadOnly LOOKUP As Short(,) = {{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 17, 16, 18, 19, 20, _
			21, 22, 23, 24, 25, 26, _
			-1, 27, -1, -1, -1, 28, _
			-1, 29, 30, 31, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 17, 16, 18, _
			19, 20, 21, 22, 23, 24, _
			25, 26, -1, 27, -1, -1, _
			-1, 28, -1, 29, 30, 31, _
			-1, -1, -1, -1}, {-1, 1, 0, 2, 3, 4, _
			5, 6, 7, 8, 9, 10, _
			-1, 11, -1, -1, -1, 12, _
			-1, 13, 14, 15, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 1, 0, 2, _
			3, 4, 5, 6, 7, 8, _
			9, 10, -1, 11, -1, -1, _
			-1, 12, -1, 13, 14, 15, _
			-1, -1, -1, -1}, {-1, 33, 32, 34, 35, 36, _
			37, 38, 39, 40, 41, 42, _
			-1, 43, -1, -1, -1, 44, _
			-1, 45, 46, 47, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 33, 32, 34, _
			35, 36, 37, 38, 39, 40, _
			41, 42, -1, 43, -1, -1, _
			-1, 44, -1, 45, 46, 47, _
			-1, -1, -1, -1}, {-1, 49, 48, 50, 51, 52, _
			53, 54, 55, 56, 57, 58, _
			-1, 59, -1, -1, -1, 60, _
			-1, 61, 62, 63, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 49, 48, 50, _
			51, 52, 53, 54, 55, 56, _
			57, 58, -1, 59, -1, -1, _
			-1, 60, -1, 61, 62, 63, _
			-1, -1, -1, -1}, {-1, 65, 64, 66, 67, 68, _
			69, 70, 71, 72, 73, 74, _
			-1, 75, -1, -1, -1, 76, _
			-1, 77, 78, 79, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 65, 64, 66, _
			67, 68, 69, 70, 71, 72, _
			73, 74, -1, 75, -1, -1, _
			-1, 76, -1, 77, 78, 79, _
			-1, -1, -1, -1}, _
			{-1, 81, 80, 82, 83, 84, _
			85, 86, 87, 88, 89, 90, _
			-1, 91, -1, -1, -1, 92, _
			-1, 93, 94, 95, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 81, 80, 82, _
			83, 84, 85, 86, 87, 88, _
			89, 90, -1, 91, -1, -1, _
			-1, 92, -1, 93, 94, 95, _
			-1, -1, -1, -1}, {-1, 97, 96, 98, 99, 100, _
			101, 102, 103, 104, 105, 106, _
			-1, 107, -1, -1, -1, 108, _
			-1, 109, 110, 111, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 97, 96, 98, _
			99, 100, 101, 102, 103, 104, _
			105, 106, -1, 107, -1, -1, _
			-1, 108, -1, 109, 110, 111, _
			-1, -1, -1, -1}, {-1, 113, 112, 114, 115, 116, _
			117, 118, 119, 120, 121, 122, _
			-1, 123, -1, -1, -1, 124, _
			-1, 125, 126, 127, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 113, 112, 114, _
			115, 116, 117, 118, 119, 120, _
			121, 122, -1, 123, -1, -1, _
			-1, 124, -1, 125, 126, 127, _
			-1, -1, -1, -1}, {-1, 129, 128, 130, 131, 132, _
			133, 134, 135, 136, 137, 138, _
			-1, 139, -1, -1, -1, 140, _
			-1, 141, 142, 143, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 129, 128, 130, _
			131, 132, 133, 134, 135, 136, _
			137, 138, -1, 139, -1, -1, _
			-1, 140, -1, 141, 142, 143, _
			-1, -1, -1, -1}, {-1, 145, 144, 146, 147, 148, _
			149, 150, 151, 152, 153, 154, _
			-1, 155, -1, -1, -1, 156, _
			-1, 157, 158, 159, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 145, 144, 146, _
			147, 148, 149, 150, 151, 152, _
			153, 154, -1, 155, -1, -1, _
			-1, 156, -1, 157, 158, 159, _
			-1, -1, -1, -1}, {-1, 161, 160, 162, 163, 164, _
			165, 166, 167, 168, 169, 170, _
			-1, 171, -1, -1, -1, 172, _
			-1, 173, 174, 175, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 161, 160, 162, _
			163, 164, 165, 166, 167, 168, _
			169, 170, -1, 171, -1, -1, _
			-1, 172, -1, 173, 174, 175, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 177, 176, 178, 179, 180, _
			181, 182, 183, 184, 185, 186, _
			-1, 187, -1, -1, -1, 188, _
			-1, 189, 190, 191, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 177, 176, 178, _
			179, 180, 181, 182, 183, 184, _
			185, 186, -1, 187, -1, -1, _
			-1, 188, -1, 189, 190, 191, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 193, 192, 194, 195, 196, _
			197, 198, 199, 200, 201, 202, _
			-1, 203, -1, -1, -1, 204, _
			-1, 205, 206, 207, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 193, 192, 194, _
			195, 196, 197, 198, 199, 200, _
			201, 202, -1, 203, -1, -1, _
			-1, 204, -1, 205, 206, 207, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 209, 208, 210, 211, 212, _
			213, 214, 215, 216, 217, 218, _
			-1, 219, -1, -1, -1, 220, _
			-1, 221, 222, 223, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 209, 208, 210, _
			211, 212, 213, 214, 215, 216, _
			217, 218, -1, 219, -1, -1, _
			-1, 220, -1, 221, 222, 223, _
			-1, -1, -1, -1}, {-1, 225, 224, 226, 227, 228, _
			229, 230, 231, 232, 233, 234, _
			-1, 235, -1, -1, -1, 236, _
			-1, 237, 238, 239, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 225, 224, 226, _
			227, 228, 229, 230, 231, 232, _
			233, 234, -1, 235, -1, -1, _
			-1, 236, -1, 237, 238, 239, _
			-1, -1, -1, -1}, {-1, 241, 240, 242, 243, 244, _
			245, 246, 247, 248, 249, 250, _
			-1, 251, -1, -1, -1, 252, _
			-1, 253, 254, 255, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 241, 240, 242, _
			243, 244, 245, 246, 247, 248, _
			249, 250, -1, 251, -1, -1, _
			-1, 252, -1, 253, 254, 255, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 17, 16, 18, 19, 20, _
			21, 22, 23, 24, 25, 26, _
			-1, 27, -1, -1, -1, 28, _
			-1, 29, 30, 31, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 17, 16, 18, _
			19, 20, 21, 22, 23, 24, _
			25, 26, -1, 27, -1, -1, _
			-1, 28, -1, 29, 30, 31, _
			-1, -1, -1, -1}, {-1, 1, 0, 2, 3, 4, _
			5, 6, 7, 8, 9, 10, _
			-1, 11, -1, -1, -1, 12, _
			-1, 13, 14, 15, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 1, 0, 2, _
			3, 4, 5, 6, 7, 8, _
			9, 10, -1, 11, -1, -1, _
			-1, 12, -1, 13, 14, 15, _
			-1, -1, -1, -1}, {-1, 33, 32, 34, 35, 36, _
			37, 38, 39, 40, 41, 42, _
			-1, 43, -1, -1, -1, 44, _
			-1, 45, 46, 47, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 33, 32, 34, _
			35, 36, 37, 38, 39, 40, _
			41, 42, -1, 43, -1, -1, _
			-1, 44, -1, 45, 46, 47, _
			-1, -1, -1, -1}, _
			{-1, 49, 48, 50, 51, 52, _
			53, 54, 55, 56, 57, 58, _
			-1, 59, -1, -1, -1, 60, _
			-1, 61, 62, 63, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 49, 48, 50, _
			51, 52, 53, 54, 55, 56, _
			57, 58, -1, 59, -1, -1, _
			-1, 60, -1, 61, 62, 63, _
			-1, -1, -1, -1}, {-1, 65, 64, 66, 67, 68, _
			69, 70, 71, 72, 73, 74, _
			-1, 75, -1, -1, -1, 76, _
			-1, 77, 78, 79, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 65, 64, 66, _
			67, 68, 69, 70, 71, 72, _
			73, 74, -1, 75, -1, -1, _
			-1, 76, -1, 77, 78, 79, _
			-1, -1, -1, -1}, {-1, 81, 80, 82, 83, 84, _
			85, 86, 87, 88, 89, 90, _
			-1, 91, -1, -1, -1, 92, _
			-1, 93, 94, 95, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 81, 80, 82, _
			83, 84, 85, 86, 87, 88, _
			89, 90, -1, 91, -1, -1, _
			-1, 92, -1, 93, 94, 95, _
			-1, -1, -1, -1}, {-1, 97, 96, 98, 99, 100, _
			101, 102, 103, 104, 105, 106, _
			-1, 107, -1, -1, -1, 108, _
			-1, 109, 110, 111, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 97, 96, 98, _
			99, 100, 101, 102, 103, 104, _
			105, 106, -1, 107, -1, -1, _
			-1, 108, -1, 109, 110, 111, _
			-1, -1, -1, -1}, {-1, 113, 112, 114, 115, 116, _
			117, 118, 119, 120, 121, 122, _
			-1, 123, -1, -1, -1, 124, _
			-1, 125, 126, 127, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 113, 112, 114, _
			115, 116, 117, 118, 119, 120, _
			121, 122, -1, 123, -1, -1, _
			-1, 124, -1, 125, 126, 127, _
			-1, -1, -1, -1}, {-1, 129, 128, 130, 131, 132, _
			133, 134, 135, 136, 137, 138, _
			-1, 139, -1, -1, -1, 140, _
			-1, 141, 142, 143, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 129, 128, 130, _
			131, 132, 133, 134, 135, 136, _
			137, 138, -1, 139, -1, -1, _
			-1, 140, -1, 141, 142, 143, _
			-1, -1, -1, -1}, _
			{-1, 145, 144, 146, 147, 148, _
			149, 150, 151, 152, 153, 154, _
			-1, 155, -1, -1, -1, 156, _
			-1, 157, 158, 159, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 145, 144, 146, _
			147, 148, 149, 150, 151, 152, _
			153, 154, -1, 155, -1, -1, _
			-1, 156, -1, 157, 158, 159, _
			-1, -1, -1, -1}, {-1, 161, 160, 162, 163, 164, _
			165, 166, 167, 168, 169, 170, _
			-1, 171, -1, -1, -1, 172, _
			-1, 173, 174, 175, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 161, 160, 162, _
			163, 164, 165, 166, 167, 168, _
			169, 170, -1, 171, -1, -1, _
			-1, 172, -1, 173, 174, 175, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 177, 176, 178, 179, 180, _
			181, 182, 183, 184, 185, 186, _
			-1, 187, -1, -1, -1, 188, _
			-1, 189, 190, 191, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 177, 176, 178, _
			179, 180, 181, 182, 183, 184, _
			185, 186, -1, 187, -1, -1, _
			-1, 188, -1, 189, 190, 191, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 193, 192, 194, 195, 196, _
			197, 198, 199, 200, 201, 202, _
			-1, 203, -1, -1, -1, 204, _
			-1, 205, 206, 207, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 193, 192, 194, _
			195, 196, 197, 198, 199, 200, _
			201, 202, -1, 203, -1, -1, _
			-1, 204, -1, 205, 206, 207, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, 209, 208, 210, 211, 212, _
			213, 214, 215, 216, 217, 218, _
			-1, 219, -1, -1, -1, 220, _
			-1, 221, 222, 223, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 209, 208, 210, _
			211, 212, 213, 214, 215, 216, _
			217, 218, -1, 219, -1, -1, _
			-1, 220, -1, 221, 222, 223, _
			-1, -1, -1, -1}, {-1, 225, 224, 226, 227, 228, _
			229, 230, 231, 232, 233, 234, _
			-1, 235, -1, -1, -1, 236, _
			-1, 237, 238, 239, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 225, 224, 226, _
			227, 228, 229, 230, 231, 232, _
			233, 234, -1, 235, -1, -1, _
			-1, 236, -1, 237, 238, 239, _
			-1, -1, -1, -1}, {-1, 241, 240, 242, 243, 244, _
			245, 246, 247, 248, 249, 250, _
			-1, 251, -1, -1, -1, 252, _
			-1, 253, 254, 255, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, 241, 240, 242, _
			243, 244, 245, 246, 247, 248, _
			249, 250, -1, 251, -1, -1, _
			-1, 252, -1, 253, 254, 255, _
			-1, -1, -1, -1}, _
			{-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}, {-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1, -1, -1, _
			-1, -1, -1, -1}}

    ' These have to come after the table definition.
    public shared ReadOnly LOOKUP_WIDTH As Integer = LOOKUP.GetUpperBound(0)
    public shared ReadOnly LOOKUP_HEIGHT As Integer = LOOKUP.GetUpperBound(1)



End Class

end namespace