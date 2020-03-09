<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="IdHaandvaerker" label="IdHaandvaerker"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete Vaerkstoejskasse</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                    <form>
                        <v-text-field v-model="Id" label="Id"></v-text-field>
                        <v-btn class="mr-4" @click="submit">submit</v-btn>
                    </form>
                </div>
        </v-row>
    </v-container>
</template>

<script>
import axios from 'axios';

export default {
     data: () => ({
      IdHaandvaerker: '',
    }),

created() {
    axios.get('http://jsonplaceholder.typicode.com/posts')
    .then(reponse => {
        this.posts = reponse.data
    })},
    
methods: {
    submit(){
        console.log(this.IdHaandvaerker)
        axios.delete('https://localhost:44339/api/Haandvaerkers/' + this.IdHaandvaerker)
    }
}
    }
</script>