<template>
    <v-row>
        <template>
           <v-col cols="12" class="d-flex justify-space-around">
                <div>
                    <p>Event Name</p>
                </div>
                <div>
                    <p>Ongoing</p>
                </div>
                <div>
                    <p> {{ countDay }} / {{ dayOfEvent }}</p>
                </div>
            </v-col> 
        </template>   
    </v-row>
    <!-- <p>hey</p> -->
</template>

<script>
export  default {
    data() {
        return {
            countDay: 5,
            dayOfEvent: 100
        }
    }
}
</script>