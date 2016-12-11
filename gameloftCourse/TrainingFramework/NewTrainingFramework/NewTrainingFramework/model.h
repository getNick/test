#pragma once
#include "Vertex.h"
#include <vector>


class model
{
public:
	model();
	~model();
	void loadModel(const char * fileName);
	void loadTexture(const char * fileName);
	Vertex *vertices;
	unsigned int *indices;
	GLuint m_hIndexBuffer;
	GLuint m_hVertexBuffer;
	GLuint textureHandle;
	int nrVertices;
	int nrIndices;
};

