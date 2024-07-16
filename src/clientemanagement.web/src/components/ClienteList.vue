<template>
    <div>
      <h1>Clientes</h1>
      <button @click="navigateToAdd">Adicionar Cliente</button>
      <ul>
        <li v-for="cliente in clientes" :key="cliente.id">
          {{ cliente.nomeEmpresa }} - {{ cliente.porte }}
          <button @click="navigateToEdit(cliente.id)">Editar</button>
          <button @click="deleteCliente(cliente.id)">Excluir</button>
        </li>
      </ul>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        clientes: [],
      };
    },
    methods: {
      async fetchClientes() {
        const response = await axios.get('/api/cliente');
        this.clientes = response.data;
      },
      navigateToAdd() {
        this.$router.push('/add');
      },
      navigateToEdit(id) {
        this.$router.push(`/edit/${id}`);
      },
      async deleteCliente(id) {
        await axios.delete(`/api/cliente/${id}`);
        this.fetchClientes();
      }
    },
    mounted() {
      this.fetchClientes();
    },
  };
  </script>
  