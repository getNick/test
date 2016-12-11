#include "stdafx.h"
#include "model.h"
#include "Vertex.h"

model::model()
{
}


model::~model()
{
}

void model::loadModel(const char * fileName)
{
	FILE * file = fopen(fileName, "r");
	if (file == NULL) {
		printf("Impossible to open the file !\n");    
		return;
	}
		/*char lineHeader[256];
		int res = fscanf(file, "%s", lineHeader);
		if (res == EOF)
			break; // EOF = Конец файла. Заканчиваем цикл чтения*/
		fscanf_s(file, "NrVertices: %d", &nrVertices);
		vertices = new Vertex[nrVertices];
		for (int i = 0; i < nrVertices; i++) {
			fscanf_s(file, " %*d. pos:[%f, %f, %f]; norm:[%*f, %*f, %*f]; binorm:[%*f, %*f, %*f]; tgt:[%*f, %*f, %*f]; uv:[%f, %f];", &vertices[i].pos.x, &vertices[i].pos.y, &vertices[i].pos.z, &vertices[i].uv.x, &vertices[i].uv.y);
			//printf(" %d. pos:[%f, %f, %f]; uv:[%f, %f];\n", i, vertices[i].pos.x, vertices[i].pos.y, vertices[i].pos.z, vertices[i].uv.x, vertices[i].uv.y);
		}
		fscanf_s(file,"");//дочитать строку до конца
		fscanf_s(file, " NrIndices: %d", &nrIndices);
		indices = new unsigned int[nrIndices];
		for (int i = 0; i < nrIndices; i+=3) {
			fscanf_s(file,"   %*d.    %d,    %d,    %d", &indices[i], &indices[i+1], &indices[i+2]);
			//printf("%d %d %d\n", indices[i], indices[i + 1], indices[i + 2]);
		}
		glGenBuffers(1, &m_hIndexBuffer);
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, m_hIndexBuffer);
		glBufferData(GL_ELEMENT_ARRAY_BUFFER, sizeof(unsigned int) * nrIndices, indices, GL_STATIC_DRAW);
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, m_hIndexBuffer);
		glGenBuffers(1, &m_hVertexBuffer); //buffer object name generation
		glBindBuffer(GL_ARRAY_BUFFER, m_hVertexBuffer); //buffer object binding
		glBufferData(GL_ARRAY_BUFFER, sizeof(Vertex)*nrVertices, vertices, GL_STATIC_DRAW); //creation and initializion of buffer onject storage
		glBindBuffer(GL_ARRAY_BUFFER, m_hVertexBuffer);
		delete[]vertices;
		delete[]indices;

}

void model::loadTexture(const char * fileName)
{
	// create the OpenGL ES texture resource and get the handle 
	glGenTextures(1, &textureHandle);
	// bind the texture to the 2D texture type 
	glBindTexture(GL_TEXTURE_2D, textureHandle);
	// create CPU buffer and load it with the image data
	int width, height, bpp;
	char * bufferTGA = LoadTGA(fileName, &width, &height, &bpp);
	// load the image data into OpenGL ES texture resource 
	if (bpp == 24) { //bpp = bits per pixel (8*number of channels, for RGBA = 8*4=32)
		glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, width, height, 0, GL_RGB, GL_UNSIGNED_BYTE, bufferTGA);
	}
	else {
		glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, bufferTGA);
	}
	// free the client memory 
	delete[] bufferTGA;

	//set the filters for minification and magnification
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR_MIPMAP_LINEAR);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);

	// generate the mipmap chain 
	glGenerateMipmap(GL_TEXTURE_2D);
	//set the wrapping modes 
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE);

	/*if (tiling == REPEAT) {
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
	}
	if (tiling == CLAMP_TO_EDGE) {
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE);
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE);
	}*/
}
